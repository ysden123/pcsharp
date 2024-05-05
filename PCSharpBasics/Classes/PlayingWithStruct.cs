using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StulSoft.PCSharpBasics.Classes
{

    public struct Struct1
    {
        public string Name;
        public int Age;
        public Struct1(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }

    public class PlayingWithStruct
    {
        public void Run()
        {
            // Create  struct instance and initialize by using "new".
            // Memory is allocated on thread stack.
            Struct1 s1 = new Struct1("Alex", 9);
            Console.WriteLine("s1 Name = {0} Age = {1}", s1.Name, s1.Age);

            // Create  new struct object. Note that  struct can be initialized
            // without using "new".
            Struct1 s2 = s1;

            // Assign values to p2 members.
            s2.Name = "Spencer";
            s2.Age = 7;
            Console.WriteLine("s2 Name = {0} Age = {1}", s2.Name, s2.Age);

            // p1 values remain unchanged because s2 is  copy.
            Console.WriteLine("s1 Name = {0} Age = {1}", s1.Name, s1.Age);
        }
    }
}
