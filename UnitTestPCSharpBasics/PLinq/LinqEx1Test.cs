using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharpBasics.PLinq;

namespace StulSoft.UnitTestPCSharpBasics.PLinq
{
    [TestClass]
    public class LinqEx1Test
    {
        [TestMethod]
        public void TestConvertStringsToIntsAndSortIt()
        {
            var result = LinqEx1.ConvertStringsToIntsAndSortIt();
            Assert.IsTrue(result[0] == 17);
            Assert.IsTrue(result[1] == 42);
            Assert.IsTrue(result[2] == 52);
        }
    }
}
