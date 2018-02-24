using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.PLinq
{
    public static class HelloLinq
    {
        public static IList<string> GetGreetingsFromArray()
        {
            var greetings = new string[] { "hello world", "hello LINQ", "hello Apress" };
            var items =
                from greeting in greetings
                where greeting.EndsWith("LINQ")
                select greeting;
            return items.ToList();
        }
        public static IList<string> GetGreetingsFromList()
        {
            var greetings = new List<string>() { "hello world", "hello LINQ", "hello Apress" };
            var items =
                from greeting in greetings
                where !greeting.EndsWith("LINQ")
                select greeting;
            return items.ToList();
        }
    }
}
