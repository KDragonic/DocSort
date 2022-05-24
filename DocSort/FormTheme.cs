using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSort
{
    public static class FormTheme
    {
        public static Color[] CurrentTheme = Standard;
        static readonly Color[] Standard = new Color[] { Color.FromArgb(230, 230, 230), Color.FromArgb(255, 255, 255) };
        static readonly Color[] Dark = new Color[] { Color.FromArgb(30, 30, 30), Color.FromArgb(50, 50, 50) };

        static void setCurrentTheme()
        {
            if (Properties.Settings.Default.theme == "Standard") CurrentTheme = Standard;
            else if (Properties.Settings.Default.theme == "Dark") CurrentTheme = Dark;
        }

        static void setFormTheme(Form form, Control[] elements)
        {
            Color Background = CurrentTheme[0];
            Color BaseСolor = CurrentTheme[1];

            form.BackColor = Background;
            foreach (var element in elements)
            {
                element.BackColor = BaseСolor;
            }
        }
    }
}
