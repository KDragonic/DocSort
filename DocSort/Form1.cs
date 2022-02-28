using System;
using System.Collections.Generic;
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
                listFile.Columns[6].Width = Properties.Settings.Default.ColWidth_7;
            }

            openButton.BackColor = Color.FromArgb(50, openButton.BackColor.R, openButton.BackColor.G, openButton.BackColor.B);
            removeButton.BackColor = Color.FromArgb(50, removeButton.BackColor.R, removeButton.BackColor.G, removeButton.BackColor.B);
            editButton.BackColor = Color.FromArgb(50, editButton.BackColor.R, editButton.BackColor.G, editButton.BackColor.B);



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
            listFile.Columns.Add("Путь");
            listFile.Columns.Add("Раширения");
            listFile.Columns.Add("Автор");
            listFile.Columns.Add("Тип");
            listFile.Columns.Add("Добавления");
            listFile.Columns.Add("Изменения");
        }

        private void genListEntry()
        {
            listFile.Items.Clear();
            foreach (var docFile in docFiles)
            {
                addEntry(docFile.name, docFile.relPath, docFile.extension, docFile.auther, docFile.type, DateTime.Now.ToString(), DateTime.Now.ToString());
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
            Properties.Settings.Default.ColWidth_7 = listFile.Columns[6].Width;
            Properties.Settings.Default.Save();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {

        }

        private void openButton_Click(object sender, EventArgs e)
        {

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
            OpenFileDialog files = new OpenFileDialog();

            if (files.ShowDialog() == DialogResult.OK)
            {
                //Get the path of specified file
                foreach (var item in files.FileNames)
                {
                    addFile(item);
                }
            }
        }

        private void addFile(string filePath)
        {
            string name = Path.GetFileNameWithoutExtension(filePath);
            string nameFill = Path.GetFileName(filePath);
            string extension = Path.GetExtension(filePath);

            string auther = "Денис";
            string type = "Отчёт";

            string relPath = "./" + auther + "/" + type + "/" + nameFill;

            docFiles.Add(new DocFile(name, relPath, auther, type, extension));
            genListEntry();
        }

        private void listFile_SelectedIndexChanged(object sender, EventArgs e)
        {
            var index = listFile.SelectedItems;

            if (index.Count >= 1)
            {
                openButton.Enabled = removeButton.Enabled = editButton.Enabled = true;
                openButton.BackColor = Color.FromArgb(255, openButton.BackColor.R, openButton.BackColor.G, openButton.BackColor.B);
                removeButton.BackColor = Color.FromArgb(255, removeButton.BackColor.R, removeButton.BackColor.G, removeButton.BackColor.B);
                editButton.BackColor = Color.FromArgb(255, editButton.BackColor.R, editButton.BackColor.G, editButton.BackColor.B);
            }
            else
            {
                openButton.Enabled = removeButton.Enabled = editButton.Enabled = false;
                openButton.BackColor = Color.FromArgb(50, openButton.BackColor.R, openButton.BackColor.G, openButton.BackColor.B);
                removeButton.BackColor = Color.FromArgb(50, removeButton.BackColor.R, removeButton.BackColor.G, removeButton.BackColor.B);
                editButton.BackColor = Color.FromArgb(50, editButton.BackColor.R, editButton.BackColor.G, editButton.BackColor.B);
            }
        }
    }
}
