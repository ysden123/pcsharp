using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Schema;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharp.JsonTest1
{
    public static class Transformer
    {
        public static string Serialize(SomeData data)
        {
            return JsonConvert.SerializeObject(data);
        }

        public static SomeData Deserialize(string json)
        {
            try
            {
                return JsonConvert.DeserializeObject<SomeData>(json);
            }
            catch(JsonSerializationException e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
    }
}
