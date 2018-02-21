using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.NameSpaces
{
    /// <summary>
    /// Playing with namespace
    /// </summary>
    public class NMSpaceTest1
    {
        public string Name { get; set; }
        public NMSpaceTest1(string name)
        {
            Name = name;
        }

        public string Test1()
        {
            return Name;
        }
    }
}
