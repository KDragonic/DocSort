using System;
using System.Windows.Forms;

namespace DocSort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            startGenColumns();
            loadingSettings();

            addFile("123", "345", "535", "356", "5356");
            addFile("123", "345", "535", "356", "5356");
            addFile("123", "345", "535", "356", "5356");
            addFile("123", "345", "535", "356", "5356");
            addFile("123", "345", "535", "356", "5356");
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
            }

            endLoadingSetting = true;
        }

        public bool addFile(params string[] list)
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
            Properties.Settings.Default.Save();
        }
    }
}
