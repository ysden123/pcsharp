using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace StulSoft.PCSharpBasics.MultiThreading.Tests
{
    [TestClass]
    public class AsyncEx1Tests
    {

        [TestMethod]
        public void Test1Test()
        {
            var mt = new AsyncEx1();
            mt.Test1();
        }
    }
}