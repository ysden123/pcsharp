using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using Optional;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharp.JsonTest1
{
    public static class Transformer
    {
        public static Option<string> Serialize(SomeData data)
        {
            try
            {
                return Option.Some(JsonConvert.SerializeObject(data));
            }
            catch (Exception e)
            {
                Console.WriteLine($"Failed serialization. Error: {e.Message}");
                return Option.None<string>();
            }
        }

        public static Option<SomeData> Deserialize(string json)
        {
            try
            {
                return Option.Some(JsonConvert.DeserializeObject<SomeData>(json));
            }
            catch (JsonSerializationException e)
            {
                Console.WriteLine($"Failed deserialization. Error: {e.Message}");
                return Option.None<SomeData>();
            }
        }
    }
}
