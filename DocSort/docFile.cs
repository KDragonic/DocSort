using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DocSort
{
    class DocFile
    {
        public string name;
        public string relPath;
        public string auther;
        public string type;
        public string extension;

        public DocFile(string name, string relPath, string auther, string type, string extension)
        {
            this.name = name;
            this.relPath = relPath;
            this.auther = auther;
            this.type = type;
            this.extension = extension;
        }
    }
}
