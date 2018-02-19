using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCSharpBasics.Classes
{
    /// <summary>
    /// Test interface
    /// </summary>
    interface Interface1
    {
        /// <summary>
        /// Defines the length.
        /// </summary>
        /// <param name="str">The string.</param>
        /// <returns></returns>
        int DefineLength(string str);

        /// <summary>
        /// Defines the text.
        /// </summary>
        /// <param name="i">The i.</param>
        /// <returns></returns>
        string DefineText(int i);
    }
}
