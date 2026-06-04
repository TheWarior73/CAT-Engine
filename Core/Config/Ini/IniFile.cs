using System;
using System.IO;

namespace CAT_Engine.Core.Config.Ini
{
    public class IniFile
    {
        private readonly string path;
        private readonly string defaultSection;
        private readonly IniParser parser;

        public IniFile(string iniPath)
        {
            path = new FileInfo(iniPath).FullName;
            defaultSection = Path.GetFileNameWithoutExtension(Environment.ProcessPath ?? "");
            parser = new IniParser(path);
        }

        /// <summary>
        /// Reads a key in the ini file
        /// </summary>
        /// <param name="Key">Key of the property</param>
        /// <param name="Section">Section where the key lives in</param>
        /// <returns>The value, or empty string if not found</returns>
        public string Read(string Key, string Section = null)
        {
            return parser.Read(Section ?? defaultSection, Key);
        }

        /// <summary>
        /// Writes a key with a value to the ini config
        /// </summary>
        public void Write(string Key, string Value, string Section = null)
        {
            parser.Write(Section ?? defaultSection, Key, Value);
            parser.Save(path);
        }

        public void DeleteKey(string Key, string Section = null)
        {
            parser.DeleteKey(Section ?? defaultSection, Key);
            parser.Save(path);
        }

        public void DeleteSection(string Section = null)
        {
            parser.DeleteSection(Section ?? defaultSection);
            parser.Save(path);
        }

        public bool KeyExists(string Key, string Section = null)
        {
            return parser.KeyExists(Section ?? defaultSection, Key);
        }
    }
}