using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharp.JsonTest1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharp.JsonTest1.Tests
{
    [TestClass]
    public class TransformerTests
    {
        [TestMethod]
        public void SerializeAndDeserializeTest()
        {
            var sd1 = new SomeData("test", 123, new List<string> { "one", "two" });
            var json = Transformer.Serialize(sd1);
            Console.WriteLine(json);
            Assert.AreEqual<string>(@"{""Name"":""test"",""Age"":123,""Stages"":[""one"",""two""]}", json);
            var sd2 = Transformer.Deserialize(json);
            Assert.AreEqual(sd1, sd2);
        }
    }
}