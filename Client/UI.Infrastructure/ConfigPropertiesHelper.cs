using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UI.Infrastructure
{
   public class ConfigPropertiesHelper
    {
        const string CONFIG_FILE_NAME = "config.properties";
        public static Dictionary<string, string> ConfigProperties = new Dictionary<string, string>();
        public static void LoadProperties()
        {
            foreach (var row in File.ReadAllLines(CONFIG_FILE_NAME))
                ConfigProperties.Add(row.Split('=')[0], string.Join("=", row.Split('=').Skip(1).ToArray()));
        }
    }
}
