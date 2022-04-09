using System.Collections.Generic;
using System.IO;
using System.Xml.Serialization;

namespace DocSort
{
    public class objSettings
    {
        public objSettings()
        {
        }

        public objSettings(List<string> type, List<string> authors)
        {
            Type = type;
            Authors = authors;
        }

        public List<string> Type { get; set; }
        public List<string> Authors { get; set; }
    }

    static class Settings
    {
        public static List<string> Type = new List<string>();
        public static List<string> Authors = new List<string>();

        

        public static void addListItem(string list, string val)
        {
            if (list == "Type") Settings.Type.Add(val);
            if (list == "Authors") Settings.Authors.Add(val);
        }

        static public void Save()
        {
            if (!IsFileSettings())
            {
                Settings.genFileSettings();
            }

            string path = getPathFileSettings();

            using (FileStream fs = new FileStream(path, FileMode.OpenOrCreate))
            {
                var obj = new objSettings(Type, Authors);
                new XmlSerializer(typeof(objSettings)).Serialize(fs, obj);
            }
        }

        static public bool genFileSettings()
        {
            if (IsFileSettings()) return false;
            string path = getPathFileSettings();

            using (FileStream fs = new FileStream(path, FileMode.Create)) {
                File.SetAttributes(path, FileAttributes.Hidden);
            };
            return true;
        }

        private static string getPathFileSettings()
        {
            string path;
            if (MainFolder.IsMainFolder())
                path = Properties.Settings.Default.pathMainFolder + "/settings.xml";
            else
            {
                MainFolder.setPathMainFolder();
                MainFolder.creatMainFolder();
                path = Properties.Settings.Default.pathMainFolder + "/settings.xml";
            }

            return path;
        }

        private static bool IsFileSettings()
        {
           return File.Exists(Properties.Settings.Default.pathMainFolder + "/settings.xml");
        }
    }
}
