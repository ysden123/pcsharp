using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PCSharpBasics.Formatting
{
    public class Formatter1
    {
        /// <summary>
        /// Formats from arguments.
        /// </summary>
        /// <param name="strArg1">The string arg1.</param>
        /// <param name="strArg2">The string arg2.</param>
        /// <param name="intArg3">The int arg3.</param>
        /// <returns>Formatted string with argument values</returns>
        public string FormatFromArgs(string strArg1, string strArg2, int intArg3)
        {
            return $"strArg1: {strArg1}, strArg2: {strArg2}, intArg3 = {intArg3}";
        }
    }
}
