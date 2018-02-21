using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharpBasics.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.Classes.Tests
{
    [TestClass()]
    public class ImplementationofI1Tests
    {
        [TestMethod()]
        public void DefineLengthTest()
        {
            var i1 = new ImplementationofI1();
            Assert.AreEqual(3, i1.DefineLength("123"));
        }

        [TestMethod()]
        public void DefineTextTest()
        {
            var i1 = new ImplementationofI1();
            Assert.AreEqual("123", i1.DefineText(123));
        }
    }
}