using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.Classes
{
    /// <summary>
    /// Using modifier <see langword="internal"/>
    /// 
    /// Internal types or members are accessible only within files in the same assembly.
    /// </summary>
    internal class ClassWithInternal
    {
        void Test()
        {
            System.Console.WriteLine("Just a test");
        }
    }
}
