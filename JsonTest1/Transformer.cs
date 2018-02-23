using Newtonsoft.Json;
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
            return JsonConvert.DeserializeObject<SomeData>(json);
        }
    }
}
