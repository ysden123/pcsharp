using NUnit.Framework;
using StulSoft.PCSharp.JsonTest1;
using System.Collections.Generic;

namespace StulSoft.PCSharp.UnitTestWithNUnit.JsonTest1.Tests
{
    [TestFixture()]
    public class SomeDataTests
    {
        [Test()]
        public void SomeDataTest()
        {
            Assert.AreNotEqual(null, new SomeData("test", 123, new List<string>() { "one", "two", "three" }));
        }

        [Test()]
        public void EqualsTest()
        {
            var sd1 = new SomeData("test", 123, new List<string>() { "one", "two", "three" });
            var sd2 = new SomeData("test", 123, new List<string>() { "one", "two", "three" });
            Assert.AreEqual(sd1, sd2);
        }

        [Test()]
        public void GetHashCodeTest()
        {
            var sd1 = new SomeData("test", 123, new List<string>() { "one", "two", "three" });
            var sd2 = new SomeData("test", 123, new List<string>() { "one", "two", "three" });
            Assert.IsTrue(sd1.GetHashCode() == sd2.GetHashCode());
        }
    }
}