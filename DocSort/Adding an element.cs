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
        internal string сlosingСode = "forced";
        public Adding_an_element(string name_text)
        {
            InitializeComponent();
            label.Text = name_text;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            сlosingСode = "cancel";
            Close();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length < 3) MessageBox.Show("Размер текста не должен быть слишком маленьким (3-15 символов)", "Ошибка");
            if (textBox.Text.Length > 15) MessageBox.Show("Размер текста не должен быть слишком большим (3-15 символов)", "Ошибка");
            else
            {
                textInput = textBox.Text;
                сlosingСode = "done";
                Close();
            }
        }
    }
}
