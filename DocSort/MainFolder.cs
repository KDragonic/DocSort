using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSort
{
    static class MainFolder
    {
        public static bool IsMainFolder()
        {
            if (Properties.Settings.Default.pathMainFolder == null || Properties.Settings.Default.pathMainFolder == "")
            {
                return false;
            }

            if (Directory.Exists(Properties.Settings.Default.pathMainFolder))
            {
                return true;
            }
            else return false;
        }

        public static void setPathMainFolder()
        {
            if (Properties.Settings.Default.pathMainFolder == null || Properties.Settings.Default.pathMainFolder == "")
            {
                FolderBrowserDialog dialog = new FolderBrowserDialog();
                dialog.Description = "Выберите папку куда будут копироватся файлы";
                while (true)
                {
                    if (dialog.ShowDialog() == DialogResult.OK)
                    {
                        Properties.Settings.Default.pathMainFolder = dialog.SelectedPath;
                        Properties.Settings.Default.Save();
                        break;
                    }
                }
            }
        }

        public static void creatMainFolder()
        {
            try
            {
                if (IsMainFolder())
                {
                    Directory.CreateDirectory(Properties.Settings.Default.pathMainFolder);
                }
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
