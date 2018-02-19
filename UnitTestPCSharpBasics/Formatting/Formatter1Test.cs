using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PCSharpBasics.Formatting;

namespace UnitTestPCSharpBasics.Formatting
{
    [TestClass]
    public class Formatter1Test
    {
        [TestMethod]
        public void TestMethod1()
        {
            var formatter1 = new Formatter1();
            var res1 = formatter1.FormatFromArgs("1st", "2nd", 3);
            Assert.AreEqual("strArg1: 1st, strArg2: 2nd, intArg3 = 3", res1);
        }
    }
}
