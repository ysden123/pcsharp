using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StulSoft.PCSharp.JsonTest1
{
    /// <summary>
    /// Some data container
    /// </summary>
    public class SomeData
    {
        private IList<string> stages = new List<String>();

        [JsonRequired]
        public string Name { get; set; }

        [JsonRequired]
        public int Age { get; set; }

        [JsonRequired]
        public IList<string> Stages
        {
            get
            {
                return new List<string>(stages);
            }
            set
            {
                stages = (value == null) ? new List<string>() : new List<string>(value);
            }
        }

        public SomeData(string name, int age, IList<string> stages)
        {
            Name = name;
            Age = age;
            Stages = stages;
        }

        public override bool Equals(object obj)
        {
            var data = obj as SomeData;
            return data != null &&
                   Name == data.Name &&
                   Age == data.Age &&
                   Stages.SequenceEqual(data.Stages);
        }

        public override int GetHashCode()
        {
            var hashCode = 1246175516;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            hashCode = hashCode * -1521134295 + Age.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<IList<string>>.Default.GetHashCode(Stages);
            return hashCode;
        }

        public override string ToString()
        {
            return $"SomeData: Name: {Name}, Age: {Age}, Stages: [{String.Join(", ", Stages.ToArray())}]";
        }
    }
}