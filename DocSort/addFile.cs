using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace DocSort
{
    public partial class AddFile : Form
    {
        internal string сlosingСode = "forced";
        internal Dictionary<string, string> data = new Dictionary<string, string>();
        public AddFile(string name)
        {
            InitializeComponent();
            textBox_name.Text = name;
            createListsComboBoxs();
        }


        public AddFile(string name, string type, string auther)
        {
            InitializeComponent();
            textBox_name.Text = name;
            comboBox_auther.Text = auther;
            comboBox_type.Text = type;
            createListsComboBoxs();
        }

        private void createListsComboBoxs()
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

        private void DoneButton_Click(object sender, EventArgs e)
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

        private void CancelButton_Click(object sender, EventArgs e)
        {
            сlosingСode = "cancel";
            Close();
        }
    }
}
