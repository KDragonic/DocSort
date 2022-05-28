using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace DocSort
{
    public partial class Form1 : Form
    {
        List<DocFile> docFiles = new List<DocFile>();

        public Form1()
        {
            InitializeComponent();
            startGenColumns();
            loadingSettings();
            MainFolder.CheckMainFolder();
            if (Properties.Settings.Default.pathMainFolder != null) Reindexing();
        }

        private bool endLoadingSetting = false;


        public void loadingSettings()
        {
            Properties.Settings.Default.Reload();

            Width = Properties.Settings.Default.WindowWidth;
            Height = Properties.Settings.Default.WindowHeight;

            if (Properties.Settings.Default.ColWidth_1 != 0)
            {
                listFile.Columns[0].Width = Properties.Settings.Default.ColWidth_1;
                listFile.Columns[1].Width = Properties.Settings.Default.ColWidth_2;
                listFile.Columns[2].Width = Properties.Settings.Default.ColWidth_3;
                listFile.Columns[3].Width = Properties.Settings.Default.ColWidth_4;
                listFile.Columns[4].Width = Properties.Settings.Default.ColWidth_5;
                listFile.Columns[5].Width = Properties.Settings.Default.ColWidth_6;
            }
            endLoadingSetting = true;
        }

        public bool addEntry(params string[] list)
        {
            listFile.Items.Add(new ListViewItem(list));
            return true;
        }

        public void startGenColumns()
        {
            listFile.Columns.Add("Имя");
            listFile.Columns.Add("Раширения");
            listFile.Columns.Add("Автор");
            listFile.Columns.Add("Тип");
            listFile.Columns.Add("Создание");
            listFile.Columns.Add("Изменения");
        }

        private void reGenListEntrys()
        {
            listFile.Items.Clear();
            foreach (var docFile in docFiles)
            {
                addEntry(docFile.name, docFile.extension, docFile.auther, docFile.type, docFile.dateCreate.ToString(), docFile.dateModified.ToString());
            }
        }

        private void Form1_Resize(object sender, EventArgs e)
        {
            if (endLoadingSetting)
            {
                Properties.Settings.Default.WindowWidth = Width;
                Properties.Settings.Default.WindowHeight = Height;
                Properties.Settings.Default.Save();
            }
        }

        private void listFile_ColumnWidthChanged(object sender, ColumnWidthChangedEventArgs e)
        {
            Properties.Settings.Default.ColWidth_1 = listFile.Columns[0].Width;
            Properties.Settings.Default.ColWidth_2 = listFile.Columns[1].Width;
            Properties.Settings.Default.ColWidth_3 = listFile.Columns[2].Width;
            Properties.Settings.Default.ColWidth_4 = listFile.Columns[3].Width;
            Properties.Settings.Default.ColWidth_5 = listFile.Columns[4].Width;
            Properties.Settings.Default.ColWidth_6 = listFile.Columns[5].Width;
            Properties.Settings.Default.Save();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            removeFiles();
        }

        private void removeFiles()
        {
            var items = listFile.SelectedItems;
            DialogResult resualt = MessageBox.Show($"Вы уверены что хотите УДАЛИТЬ {items.Count} файлов?", "Предупреждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (resualt.ToString() == "Yes")
            {
                foreach (ListViewItem item in items)
                {
                    var path = Properties.Settings.Default.pathMainFolder + "\\" + item.SubItems[2].Text + "\\" + item.SubItems[3].Text + "\\" + item.SubItems[0].Text + item.SubItems[1].Text;
                    File.Delete(path);
                }
            }
            Reindexing();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openFiles();
        }

        private void openFiles()
        {
            var items = listFile.SelectedItems;
            if (items.Count > 6)
            {
                DialogResult resualt = MessageBox.Show($"Вы уверены что хотите отрыть {items.Count} файлов?", "Предупреждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resualt.ToString() == "No") return;
            }
            foreach (ListViewItem item in items)
            {
                var path = Properties.Settings.Default.pathMainFolder + "\\" + item.SubItems[2].Text + "\\" + item.SubItems[3].Text + "\\" + item.SubItems[0].Text + item.SubItems[1].Text;
                Process.Start(path);
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            addFiles();
        }

        private void addFiles()
        {
            OpenFileDialog files = new OpenFileDialog
            {
                Multiselect = true
            };

            if (files.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                foreach (var path in files.FileNames)
                {
                    string name = Path.GetFileNameWithoutExtension(path);
                    if (name == "") name = "(пусто)";
                    addFile form = new addFile(name);
                    form.ShowDialog();
                    if (form.сlosingСode == "done")
                    {
                        Dictionary<string, object> data = new Dictionary<string, object>();
                        if (form.data["name"] == null) return;
                        if (form.data["auther"] == null) return;
                        if (form.data["type"] == null) return;
                        data["name"] = form.data["name"];
                        data["auther"] = form.data["auther"];
                        data["type"] = form.data["type"];
                        data["extension"] = Path.GetExtension(path);
                        data["dateCreate"] = File.GetCreationTime(path);
                        data["dateModified"] = File.GetLastWriteTime(path);
                        string newPath = Properties.Settings.Default.pathMainFolder + "\\" + data["auther"] + "\\" + data["type"];

                        DocFile file = new DocFile(data, newPath, path);
                        docFiles.Add(file);
                    }
                }
                reGenListEntrys();
            }
        }

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            var file = listFile.SelectedItems;
            var buttons = new Button[] { openButton, removeButton, editButton, openInFolderButton };
            if (file.Count >= 1)
            {
                foreach (var button in buttons)
                {
                    button.Enabled = true;
                    button.BackColor = Color.FromArgb(255, button.BackColor.R, button.BackColor.G, button.BackColor.B);
                }
            }
            else
            {
                foreach (var button in buttons)
                {
                    button.Enabled = false;
                    button.BackColor = Color.FromArgb(50, button.BackColor.R, button.BackColor.G, button.BackColor.B);
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Reindexing()
        {
            docFiles.Clear();
            MainFolder.CheckMainFolder();
            string[] FilesPath = Directory.GetFiles(Properties.Settings.Default.pathMainFolder, "*.*", SearchOption.AllDirectories);
            foreach (var filePath in FilesPath)
            {
                docFiles.Add(new DocFile(filePath));
            }
            reGenListEntrys();
        }

        private void button_reindexing_Click(object sender, EventArgs e)
        {
            Reindexing();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Settings settings = new Settings();
            settings.ShowDialog();
        }

        private void openInFolderButton_Click(object sender, EventArgs e)
        {
            openFileInFolder();
        }

        private void openFileInFolder()
        {
            var items = listFile.SelectedItems;
            List<string> folders = new List<string>();
            foreach (ListViewItem listViewItem in items)
            {
                string path = Properties.Settings.Default.pathMainFolder + "\\" + listViewItem.SubItems[2].Text + "\\" + listViewItem.SubItems[3].Text;
                if (!folders.Contains(path)) folders.Add(path);
            }
            if (folders.Count > 4)
            {
                DialogResult resualt = MessageBox.Show($"Вы уверены что хотите отрыть {items.Count} файлов?", "Предупреждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resualt.ToString() != "Yes") return;
            }
            foreach (var folder in folders)
            {
                Console.WriteLine(folder);
                Process.Start("explorer.exe", folder);
            }
        }

        private void createReport(bool isAll)
        {
            Microsoft.Office.Interop.Word.Application wordApp = new Microsoft.Office.Interop.Word.Application();
            Document wordDoc = wordApp.Documents.Add();

            //Добавляем параграф в конец документа
            var Paragraph = wordApp.ActiveDocument.Paragraphs.Add();
            //Получаем диапазон
            var tableRange = Paragraph.Range;

            if (isAll)
            {
                //Добавляем таблицу
                wordApp.ActiveDocument.Tables.Add(tableRange, docFiles.Count + 1, 5);

                var table = wordApp.ActiveDocument.Tables[wordApp.ActiveDocument.Tables.Count];
                table.set_Style("Сетка таблицы");
                table.ApplyStyleHeadingRows = true;
                table.ApplyStyleLastRow = false;
                table.ApplyStyleFirstColumn = true;
                table.ApplyStyleLastColumn = false;
                table.ApplyStyleRowBands = true;
                table.ApplyStyleColumnBands = false;


                table.Cell(1, 1).Range.Text = "Название";
                table.Cell(1, 2).Range.Text = "Автор";
                table.Cell(1, 3).Range.Text = "Тип";
                table.Cell(1, 4).Range.Text = "Время создания";
                table.Cell(1, 5).Range.Text = "Время изменения";

                table.Cell(1, 1).Range.Font.Bold = 1;
                table.Cell(1, 2).Range.Font.Bold = 1;
                table.Cell(1, 3).Range.Font.Bold = 1;
                table.Cell(1, 4).Range.Font.Bold = 1;
                table.Cell(1, 5).Range.Font.Bold = 1;

                for (int i = 0; i < docFiles.Count; i++)
                {
                    var item = docFiles[i];
                    table.Cell(i + 2, 1).Range.Text =  item.name;
                    table.Cell(i + 2, 2).Range.Text =  item.auther;
                    table.Cell(i + 2, 3).Range.Text = item.type;
                    table.Cell(i + 2, 4).Range.Text =  item.dateCreate.ToString();
                    table.Cell(i + 2, 5).Range.Text = item.dateModified.ToString();
                }
            }
            else
            {
                var items = listFile.Items;

                wordApp.ActiveDocument.Tables.Add(tableRange, items.Count + 1, 5);

                var table = wordApp.ActiveDocument.Tables[wordApp.ActiveDocument.Tables.Count];
                table.set_Style("Сетка таблицы");
                table.ApplyStyleHeadingRows = true;
                table.ApplyStyleLastRow = false;
                table.ApplyStyleFirstColumn = true;
                table.ApplyStyleLastColumn = false;
                table.ApplyStyleRowBands = true;
                table.ApplyStyleColumnBands = false;


                table.Cell(1, 1).Range.Text = "Название";
                table.Cell(1, 2).Range.Text = "Автор";
                table.Cell(1, 3).Range.Text = "Тип";
                table.Cell(1, 4).Range.Text = "Время создания";
                table.Cell(1, 5).Range.Text = "Время изменения";

                table.Cell(1, 1).Range.Font.Bold = 1;
                table.Cell(1, 2).Range.Font.Bold = 1;
                table.Cell(1, 3).Range.Font.Bold = 1;
                table.Cell(1, 4).Range.Font.Bold = 1;
                table.Cell(1, 5).Range.Font.Bold = 1;

                for (int i = 0; i < items.Count; i++)
                {
                    var item = items[i];
                    table.Cell(i + 2, 1).Range.Text = item.SubItems[0].Text;
                    table.Cell(i + 2, 2).Range.Text = item.SubItems[2].Text;
                    table.Cell(i + 2, 3).Range.Text = item.SubItems[3].Text;
                    table.Cell(i + 2, 4).Range.Text = item.SubItems[4].Text;
                    table.Cell(i + 2, 5).Range.Text = item.SubItems[5].Text;
                }
            }
            //"Приукрашиваем" таблицу, иначе по-дефолту она будет без линий
            wordApp.Visible = true;
        }

        private void input_FastSearch_TextChanged(object sender, EventArgs e)
        {
            fastSerch(((TextBox)sender).Text);
        }

        private void fastSerch(string text)
        {
            var list = Array.FindAll(docFiles.ToArray(), file => file.name.StartsWith(text));
            listFile.Items.Clear();
            foreach (var item in list)
            {
                addEntry(item.name, item.extension, item.auther, item.type, item.dateCreate.ToString(), item.dateModified.ToString());
            }
        }

        private void button_ExpandedOutput_Click(object sender, EventArgs e)
        {
            Filter filter = new Filter();
            filter.ShowDialog();
            Dictionary<string, object> param = filter.param;
            filter.Dispose();
            var list = docFiles;
            if (param.ContainsKey("Автор"))
            {
                list = list.FindAll(file => file.auther.IndexOf((string)param["Автор"]) > -1);
            }

            if (param.ContainsKey("Тип"))
            {
                list = list.FindAll(file => file.type.IndexOf((string)param["Тип"]) > -1);
            }

            if (param.ContainsKey("Дата"))
            {
                DateTime[] buff = (DateTime[])param["Дата"];
                DateTime dateStart = buff[0];
                DateTime dateEnd = buff[1];

                list = list.FindAll(file => file.dateCreate >= dateStart && file.dateCreate < dateEnd);
            }


            listFile.Items.Clear();
            foreach (var item in list)
            {
                addEntry(item.name, item.extension, item.auther, item.type, item.dateCreate.ToString(), item.dateModified.ToString());
            }

        }

        private void ReportAllButton_Click(object sender, EventArgs e)
        {
            createReport(true);
        }

        private void ReportOutputButton_Click(object sender, EventArgs e)
        {
            createReport(false);
        }

        private void переиндексацияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Reindexing();
        }

        private void выделитьВсёToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listFile.Items)
            {
                item.Selected = true;
            } 
        }

        private void убратьВыделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listFile.Items)
            {
                item.Selected = false;
            }
        }

        private void инвертироватьВыделенияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listFile.Items)
            {
                item.Selected = !item.Selected;
            }
        }

        private void убратьФилтрациюToolStripMenuItem_Click(object sender, EventArgs e)
        {
            reGenListEntrys();
        }

        private void добавитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addFiles();
        }

        private void удалитьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            removeFiles();
        }

        private void открытьФайлToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFiles();
        }

        private void открытьФайлВПапкеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileInFolder();
        }
    }
}
