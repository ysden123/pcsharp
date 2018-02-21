using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharpBasics.Lambda;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.Lambda.Tests
{
    [TestClass()]
    public class LambdaEx1Tests
    {
        [TestMethod()]
        public void SimpleFunctionTest()
        {
            var t = new LambdaEx1();
            Assert.AreEqual<string>("i=123", t.SimpleFunction(123));
        }

        [TestMethod()]
        public void ArrowFunction1Test()
        {
            var t = new LambdaEx1();
            Assert.AreEqual<string>("i=123", t.ArrowFunction1(123));
        }

        [TestMethod()]
        public void UseFunctionTest()
        {
            var t = new LambdaEx1();
            Assert.AreEqual<string>("123", t.UseFunction(123, i => $"{i}"));
        }
    }
}