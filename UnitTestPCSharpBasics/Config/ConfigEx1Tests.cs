using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCSharpBasics.Config;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCSharpBasics.Config.Tests
{
    [TestClass()]
    public class ConfigEx1Tests
    {
        [TestMethod()]
        public void DefineSetting1Test()
        {
            var conf = new ConfigEx1();
            var v = conf.DefineSetting1();
            Assert.AreNotEqual(conf.DefineSetting1(), null);
            Assert.AreEqual<String>("value for setting1", conf.DefineSetting1());
        }
    }
}