using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.XMLserialization
{
    /// <summary>
    /// Some configuration
    /// </summary>
    public class Config1
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Config1()
        {
        }

        public Config1(int id, string name)
        {
            Id = id;
            Name = name;
        }

        public override bool Equals(object obj)
        {
            var config = obj as Config1;
            return config != null &&
                   Id == config.Id &&
                   Name == config.Name;
        }

        public override int GetHashCode()
        {
            var hashCode = -1919740922;
            hashCode = hashCode * -1521134295 + Id.GetHashCode();
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
            return hashCode;
        }

        public override string ToString()
        {
            return $"Config1[Id={Id}, Name:{Name}]";
        }
    }
}
