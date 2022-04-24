using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSort
{
    public partial class Settings: Form
    {
        public Settings()
        {
            InitializeComponent();
            if (Properties.Settings.Default.additional_decorations) label_additional_decorations.ForeColor = Color.FromArgb(40, 170, 40);
            else label_additional_decorations.ForeColor = Color.FromArgb(170, 40, 40);

            if (Properties.Settings.Default.advanced_mode) label_advanced_mode.ForeColor = Color.FromArgb(90, 255, 40);
            else label_advanced_mode.ForeColor = Color.FromArgb(170, 40, 40);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.types.Clear();
            foreach (ListViewItem type in listView_types.Items) Properties.Settings.Default.types.Add(type.Text);
            foreach (ListViewItem auther in listView_authors.Items) Properties.Settings.Default.authers.Add(auther.Text);
            Properties.Settings.Default.Save();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (var type in Properties.Settings.Default.types) listView_types.Items.Add(type);
            foreach (var auther in Properties.Settings.Default.authers) listView_authors.Items.Add(auther);
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label_additional_decorations_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.additional_decorations = !Properties.Settings.Default.additional_decorations;
            if (Properties.Settings.Default.additional_decorations) label_additional_decorations.ForeColor = Color.FromArgb(40, 170, 40);
            else label_additional_decorations.ForeColor = Color.FromArgb(170, 40, 40);
            Properties.Settings.Default.Save();
        }

        private void label_advanced_mode_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.advanced_mode = !Properties.Settings.Default.advanced_mode;
            if (Properties.Settings.Default.advanced_mode) label_advanced_mode.ForeColor = Color.FromArgb(40, 170, 40);
            else label_advanced_mode.ForeColor = Color.FromArgb(170, 40, 40);
            Properties.Settings.Default.Save();
        }

        private void button_add_types_Click(object sender, EventArgs e)
        {
            Adding_an_element form = new Adding_an_element("Добавить пункт ТИП в список");
            form.ShowDialog();
            if (form.textInput.Length >= 3) { listView_types.Items.Add(form.textInput); }
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
            Adding_an_element form = new Adding_an_element("Добавить пункт ТИП в список");
            form.ShowDialog();
            if (form.textInput.Length >= 3) { listView_types.Items.Add(form.textInput); }
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
