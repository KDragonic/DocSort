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
    public partial class addFile : Form
    {
        internal string сlosingСode = "forced";
        internal Dictionary<string, string> data = new Dictionary<string, string>();
        public addFile(string name)
        {
            InitializeComponent();
            textBox_name.Text = name;
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
    }
}
