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
    public partial class Adding_an_element : Form
    {
        internal string textInput;
        public Adding_an_element(string name_text)
        {
            InitializeComponent();
            label1.Text = name_text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text.Length <= 3) MessageBox.Show("Размер текста не должен быть слишком маленким (Более 2 символов)", "Ошибка");
            else
            {
                textInput = textBox1.Text;
                Close();
            }
        }

        private void Adding_an_element_Load(object sender, EventArgs e)
        {

        }
    }
}
