using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.Classes
{
    public class ImplementationofI1 : Interface1
    {
        /// <summary>
        /// Defines the length.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        public int DefineLength(string str)
        {
            return str.Length;
        }

        /// <summary>
        /// Defines the text.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        public string DefineText(int i)
        {
            return $"{i}";
        }
    }
}
