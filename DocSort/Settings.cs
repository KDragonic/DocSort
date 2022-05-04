using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace DocSort
{
    public partial class Settings : Form
    {
        internal string сlosingСode = "forced";
        public Settings()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.types.Clear();
            Properties.Settings.Default.authers.Clear();
            foreach (ListViewItem type in listView_types.Items) Properties.Settings.Default.types.Add(type.Text);
            foreach (ListViewItem auther in listView_authors.Items) Properties.Settings.Default.authers.Add(auther.Text);
            Properties.Settings.Default.Save();
            сlosingСode = "done";
            Close();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            listView_types.Items.Clear();
            listView_authors.Items.Clear();
            foreach (var type in Properties.Settings.Default.types) listView_types.Items.Add(type);
            foreach (var auther in Properties.Settings.Default.authers) listView_authors.Items.Add(auther);
        }

        private void button_add_types_Click(object sender, EventArgs e)
        {
            Adding_an_element form = new Adding_an_element("Добавить ТИП в список");
            form.ShowDialog();
            if (form.сlosingСode == "done")
            {
                if (form.textInput.Length >= 3)
                {
                    listView_types.Items.Add(form.textInput);
                }
            }
            form.Dispose();
        }

        private void button_remove_types_Click(object sender, EventArgs e)
        {
            var items = listView_types.SelectedItems;
            if (items.Count > 0)
            {
                DialogResult resualt = MessageBox.Show($"Вы уверены что хотите УДАЛИТЬ {items.Count} пунктов из ТИПЫ?", "Предупреждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resualt.ToString() == "Yes")
                {
                    foreach (ListViewItem item in items)
                    {
                        item.Remove();
                        Console.WriteLine($"Пункт {item.Text} удалён");
                    }
                }
            }
        }

        private void button_add_author_Click(object sender, EventArgs e)
        {
            Adding_an_element form = new Adding_an_element("Добавить АВТОРА в список");
            form.ShowDialog();
            if (form.сlosingСode == "done")
            {
                if (form.textInput.Length >= 3)
                {
                    listView_authors.Items.Add(form.textInput);
                }
            }
            form.Dispose();
        }

        private void button_remove_author_Click(object sender, EventArgs e)
        {
            var items = listView_authors.SelectedItems;
            if (items.Count > 0)
            {
                DialogResult resualt = MessageBox.Show($"Вы уверены что хотите УДАЛИТЬ {items.Count} пунктов из АВТОРЫ?", "Предупреждения", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (resualt.ToString() == "Yes")
                {
                    foreach (ListViewItem item in items)
                    {
                        item.Remove();
                        Console.WriteLine($"Пункт {item.Text} удалён");
                    }
                }
            }
        }
    }
}
