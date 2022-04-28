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
        public static void CheckMainFolder()
        {
            if (Properties.Settings.Default.pathMainFolder != null
                && Properties.Settings.Default.pathMainFolder != ""
                && Properties.Settings.Default.pathMainFolder.Length >= 4)
            {
                if (!Directory.Exists(Properties.Settings.Default.pathMainFolder))
                {
                    setPathMainFolder();
                }
            }
            else setPathMainFolder();
        }

        public static void setPathMainFolder()
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
}
