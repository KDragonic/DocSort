using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DocSort
{
    public partial class addFile : Form
    {
        internal string сlosingСode = "forced";
        internal Dictionary<string, string> data = new Dictionary<string, string>();
        public addFile(string name)
        {
            InitializeComponent();
            textBox_name.Text = name;
            creatListsComboBoxs();
        }

        private void creatListsComboBoxs()
        {
            comboBox_auther.Items.Clear();
            comboBox_type.Items.Clear();
            foreach (var item in Properties.Settings.Default.authers)
            {
                comboBox_auther.Items.Add(item);
            }
            foreach (var item in Properties.Settings.Default.types)
            {
                comboBox_type.Items.Add(item);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(textBox_name.Text) &&
                !String.IsNullOrEmpty(comboBox_type.Text) &&
                !String.IsNullOrEmpty(comboBox_auther.Text))
            {
                data.Add("name", textBox_name.Text);
                data.Add("type", comboBox_type.Text);
                data.Add("auther", comboBox_auther.Text);
                сlosingСode = "done";
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            сlosingСode = "cancel";
            Close();
        }

        private bool сorrect_input(string text)
        {
            if (text == "") return false;
            return true;
        }

        private bool Is_there_an_item_in_the_list(string text, StringCollection list)
        {
            return list.Contains(text);
        }

        private void button_add_auther_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.authers.Add(comboBox_auther.Text);
            creatListsComboBoxs();
        }

        private void button_add_type_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.authers.Add(comboBox_type.Text);
            creatListsComboBoxs();
        }

        private void comboBox_auther_TextUpdate(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (сorrect_input(comboBox.Text)) return;
            else if (Is_there_an_item_in_the_list(comboBox.Text, Properties.Settings.Default.authers))
            {
                button_add_auther.BackColor = Color.FromArgb(
                    50,
                    button_add_auther.BackColor.R,
                    button_add_auther.BackColor.G,
                    button_add_auther.BackColor.B
                );
                button_add_auther.Enabled = false;
            }
            else
            {
                button_add_auther.BackColor = Color.FromArgb(
                    255,
                    button_add_auther.BackColor.R,
                    button_add_auther.BackColor.G,
                    button_add_auther.BackColor.B
                );
                button_add_auther.Enabled = true;
            }
        }

        private void comboBox_type_TextUpdate(object sender, EventArgs e)
        {
            ComboBox comboBox = (ComboBox)sender;
            if (сorrect_input(comboBox.Text)) return;
            else if(Is_there_an_item_in_the_list(comboBox.Text, Properties.Settings.Default.types))
            {
                button_add_type.BackColor = Color.FromArgb(
                    50,
                    button_add_type.BackColor.R,
                    button_add_type.BackColor.G,
                    button_add_type.BackColor.B
                );
                button_add_type.Enabled = false;
            }
            else
            {
                button_add_type.BackColor = Color.FromArgb(
                    255,
                    button_add_type.BackColor.R,
                    button_add_type.BackColor.G,
                    button_add_type.BackColor.B
                );
                button_add_type.Enabled = true;
            }
        }
    }
}
