using Microsoft.VisualStudio.TestTools.UnitTesting;
using StulSoft.PCSharpBasics.Classes;

namespace StulSoft.UnitTestPCSharpBasics.Classes
{
    [TestClass()]
    public class PlayingWithStructTests
    {
        [TestMethod()]
        public void PlayingWithStructTest() {
            var pws = new PlayingWithStruct();
            pws.Run();
        }
    }
}
