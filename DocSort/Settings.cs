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
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Settings_Load(object sender, EventArgs e)
        {
            foreach (var type in Properties.Settings.Default.types) listView1.Items.Add(type);
            foreach (var auther in Properties.Settings.Default.authers) listView2.Items.Add(auther);
        }
    }
}
