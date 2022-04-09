using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace DocSort
{
    internal class PhysicalFile
    {
        public DocFile link;
        public string absPath;

        public PhysicalFile(DocFile docFile, string path)
        {
            this.link = link;
            Console.WriteLine(isFolderPresent(docFile));
        }


        private bool isFolderPresent(DocFile link)
        {
            string path = Properties.Settings.Default.pathMainFolder + "/" + link.auther + "/" + link.type;
            Console.WriteLine(path);
            return Directory.Exists(path);
        }
    }
}
