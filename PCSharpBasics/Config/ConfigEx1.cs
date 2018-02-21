using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace StulSoft.PCSharpBasics.Config
{
    public class ConfigEx1
    {
        public string DefineSetting1()
        {
            return ConfigurationManager.AppSettings.Get("setting1");
        }
        public string DefineSetting2()
        {
            return ConfigurationManager.AppSettings["setting1"];
        }
    }
}
