using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharpBasics.PLinq;

namespace StulSoft.UnitTestPCSharpBasics.PLinq
{
    [TestClass]
    public class HelloLinqTest
    {
        [TestMethod]
        public void TestGetGreetings()
        {
            var result = HelloLinq.GetGreetings();
            Assert.IsTrue(result.Count == 1);
        }
    }
}
