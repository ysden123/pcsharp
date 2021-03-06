﻿using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StulSoft.PCSharpBasics.NameSpaces.Tests
{
    [TestClass()]
    public class NMSpaceTest1Tests
    {
        [TestMethod()]
        public void NMSpaceTest1Test()
        {
            Assert.AreNotEqual(null, new NMSpaceTest1("test"));
        }

        [TestMethod()]
        public void Test1Test()
        {
            var tmp = new NMSpaceTest1("test");
            Assert.AreEqual<string>("test", tmp.Test1());
        }
    }
}