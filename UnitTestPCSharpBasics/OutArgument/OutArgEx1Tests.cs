using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharpBasics.OutArgument;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.OutArgument.Tests
{
    [TestClass()]
    public class OutArgEx1Tests
    {
        [TestMethod()]
        public void Method1Test()
        {
            var text = "";
            var result = OutArgEx1.Method1(123, out text);
            Assert.AreEqual(true, result);
            Assert.AreEqual<string>("i=123", text);
        }
    }
}