using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharpBasics.PLinq;

namespace StulSoft.UnitTestPCSharpBasics.PLinq
{
    [TestClass]
    public class HelloLinqTest
    {
        [TestMethod]
        public void TestGetGreetingsFromArray()
        {
            var result = HelloLinq.GetGreetingsFromArray();
            Assert.IsTrue(result.Count == 1);
        }

        [TestMethod]
        public void TestGetGreetingsFromList()
        {
            var result = HelloLinq.GetGreetingsFromList();
            Assert.IsTrue(result.Count == 2);
        }
    }
}
