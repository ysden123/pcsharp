using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.Lambda
{
    public class LambdaEx1
    {
        /// <summary>
        /// Usual method definition
        /// </summary>
        /// <param name="i">input</param>
        /// <returns>result</returns>
        public string SimpleFunction(int i)
        {
            return $"i={i}";
        }

        /// <summary>
        /// Method definition with arrow
        /// </summary>
        /// <param name="i">input</param>
        /// <returns>result</returns>
        public string ArrowFunction1(int i) => $"i={i}";

        /// <summary>
        /// Usage of function as input parameter
        /// </summary>
        /// <param name="i">input</param>
        /// <param name="f">a function</param>
        /// <returns>result</returns>
        public string UseFunction(int i, Func<int, string> f)
        {
            return f(i);
        }
    }
}
