using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.OutArgument
{
    /// <summary>
    /// Playing with the out argument
    /// </summary>
    public static class OutArgEx1
    {
        public static bool Method1(int i, out string text)
        {
            text = String.Format("i={0}", i);
            return true;
        }
    }
}
