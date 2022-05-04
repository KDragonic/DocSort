using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DocSort
{
    class DocFile
    {
        public string name;
        public string auther;
        public string type;
        public string extension;
        public DateTime dateCreate;
        public DateTime dateModified;

        public DocFile(Dictionary<string, object> data, string pathFolder, string oldPath)
        {
            this.name = (string)data["name"];
            this.auther = (string)data["auther"];
            this.type = (string)data["type"];
            this.extension = (string)data["extension"];
            this.dateCreate = (DateTime)data["dateCreate"];
            this.dateModified = (DateTime)data["dateModified"];

            if (!isFolder(pathFolder)) creatFolders(pathFolder);
            copyFile(Path.Combine(pathFolder, (string)data["name"] + (string)data["extension"]), oldPath);
        }

        public DocFile(string path)
        {
            string name = Path.GetFileNameWithoutExtension(path);
            if (name == "") name = "(пусто)";
            string extension = Path.GetExtension(path);
            var folderNames = getFolderNames(path);
            this.name = name;
            this.auther = folderNames["auther"];
            this.type = folderNames["type"];
            this.extension = extension;
            this.dateCreate = File.GetCreationTime(path);
            this.dateModified = File.GetLastWriteTime(path);
        }

        private Dictionary<string, string> getFolderNames(string path)
        {
            Dictionary<string, string> folderNames = new Dictionary<string, string>();
            // "auther", "type", "name";

            var folderNamesAll = path.Split('\\');
            folderNames["type"] = folderNamesAll[folderNamesAll.Length - 2];
            folderNames["auther"] = folderNamesAll[folderNamesAll.Length - 3];

            return folderNames;
        }

        private void creatFolders(string pathFolder) => Directory.CreateDirectory(pathFolder);
        private bool isFolder(string pathFolder) => Directory.Exists(pathFolder);
        private void copyFile(string newPath, string oldPath)
        {
            if (File.Exists(newPath)) MessageBox.Show($"Файл по пути {newPath} уже есть, файл не добавлен выберите другое имя", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else File.Copy(oldPath, newPath);
        }

        protected void removeFile(string path) => File.Delete(path);
    }
}
