using CAT_Engine.Core.Config.Ini;
using CAT_Engine.Core.Debug;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace CAT_Engine.Core.Config
{
    public static class ConfigurationManager
    {
        private static string engineConfigFilePath = Path.Combine("Config", "Engine");

        /// <summary>
        /// Returns the ini file at the location "WorkingDir/Config/Engine"
        /// </summary>
        /// <param name="name">Ini file name, make sure to include the extension!</param>
        /// <returns>The ini file to read/write from</returns>
        public static IniFile GetEngineConfigFile(string name)
        {
            string filePath = Path.Combine(engineConfigFilePath, name);
            IniFile file = new IniFile(filePath);

            return file;
        }
    }
}
