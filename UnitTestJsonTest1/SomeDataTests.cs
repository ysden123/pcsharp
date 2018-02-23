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
    public class SomeDataTests
    {
        [TestMethod]
        public void SomeDataConstructorTest()
        {
            var sd = new SomeData("test", 123, new List<string> { "one", "two" });
            Assert.AreNotEqual(null, sd);
        }

        [TestMethod]
        public void ToStringTest()
        {
            var sd = new SomeData("test", 123, new List<string> { "one", "two" });
            var str = sd.ToString();
            //Console.WriteLine(str);
            Assert.AreEqual<string>("SomeData: Name: test, Age: 123, Stages: [one, two]", str);
        }

        [TestMethod]
        public void EqualsTest()
        {
            var sd1 = new SomeData("test", 123, new List<string> { "one", "two" });
            var sd2 = new SomeData("test", 123, new List<string> { "one", "two" });
            Assert.AreEqual<SomeData>(sd1, sd2);
        }
    }
}