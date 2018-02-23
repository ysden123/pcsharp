using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace StulSoft.PCSharp.JsonTest1.Tests
{
    [TestClass]
    public class TransformerTests
    {
        [TestMethod]
        public void SerializeAndDeserializeTest()
        {
            var sd1 = new SomeData("test", 123, new List<string> { "one", "two" });
            var optionJson = Transformer.Serialize(sd1);
            if (optionJson.HasValue)
            {
                var json = optionJson.ValueOr("");
                Console.WriteLine(json);
                Assert.AreEqual<string>(@"{""Name"":""test"",""Age"":123,""Stages"":[""one"",""two""]}", json);
                var optionSd2 = Transformer.Deserialize(json);
                if (optionSd2.HasValue)
                {
                    var sd2 = optionSd2.ValueOr(() => null);
                    Assert.AreEqual(sd1, sd2);
                }
                else
                {
                    Assert.Fail("Deserialize failed");
                }
            }
            else
            {
                Assert.Fail("Serialize failed");
            }
        }

        [TestMethod]
        public void SerializeDeserialize_WithFail_Test()
        {
            // Missing age
            var badJson = @"{""Name"":""test"",""Stages"":[""one"",""two""]}";
            var optionSd = Transformer.Deserialize(badJson);
            if (optionSd.HasValue)
            {
                Assert.Fail("Deserialized with missed property");
            }
        }
    }
}