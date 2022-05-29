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
    public partial class Filter : Form
    {
        internal Dictionary<string, object> param = new Dictionary<string, object>();
        public Filter()
        {
            InitializeComponent();
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
            if (checkBox_auther.Checked) param.Add("Автор", comboBox_auther.Text);
            if (checkBox_type.Checked) param.Add("Тип", comboBox_type.Text);
            if (checkBox_dateTimePickers.Checked) param.Add("Дата", new DateTime[] { dateTimePicker1.Value, dateTimePicker2.Value });
            Close();
        }

        private void checkBox_auther_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                comboBox_auther.Enabled = true;
            }
            else
            {
                comboBox_auther.Enabled = false;
            }
        }

        private void checkBox_type_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                comboBox_type.Enabled = true;
            }
            else
            {
                comboBox_type.Enabled = false;
            }
        }

        private void checkBox_dateTimePickers_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = (CheckBox)sender;
            if (checkBox.Checked)
            {
                dateTimePicker1.Enabled = true;
                dateTimePicker2.Enabled = true;
            }
            else
            {
                dateTimePicker1.Enabled = false;
                dateTimePicker2.Enabled = false;
            }
        }
    }
}
