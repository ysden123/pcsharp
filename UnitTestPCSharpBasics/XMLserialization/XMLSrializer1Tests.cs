using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharpBasics.XMLserialization;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCSharpBasics.XMLserialization.Tests
{
    [TestClass()]
    public class XMLSrializer1Tests
    {
        /// <summary>
        /// Serializes to XML string test.
        /// </summary>
        [TestMethod()]
        public void SerializeToXmlStringTest()
        {
            var config1 = new Config1(1, "yur");
            var xml = XMLSrializer1.SerializeToXmlString<Config1>(config1);
            Console.WriteLine(xml);

            xml = XMLSrializer1.SerializeToXmlString<Config1>(config1, false);
            Console.WriteLine(xml);
        }

        [TestMethod()]
        [Ignore]
        public void SerializeToXmlFileTest()
        {
        }

        [TestMethod()]
        public void DeserializeFromXmlStringTest()
        {
            var config1 = new Config1(1, "yur");
            var xml = XMLSrializer1.SerializeToXmlString<Config1>(config1);
            var config2 = XMLSrializer1.DeserializeFromXmlString<Config1>(xml);
            Assert.AreEqual<Config1>(config1, config2);
        }

        [TestMethod()]
        [Ignore]
        public void DeserializeFromXmlFileTest()
        {

        }
    }
}