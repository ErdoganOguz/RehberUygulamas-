using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace RehberUygulaması.Localization
{
    public class ChangeLanguange
    {
        public void UpdateConfig(string key, string value)
        {
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            var settings = config.AppSettings.Settings;

            var entry = settings[key];
            entry.Value = value;
            config.Save(ConfigurationSaveMode.Modified);


        }
    }
}
