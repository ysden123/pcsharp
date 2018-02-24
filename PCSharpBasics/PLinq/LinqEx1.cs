using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.PLinq
{
    public static class LinqEx1
    {
        public static int[] ConvertStringsToIntsAndSortIt()
        {
            var strings = new string[] { "0042", "17", "52" };
            return strings.Select(s => Int32.Parse(s)).OrderBy(i => i).ToArray();
        }
    }
}
