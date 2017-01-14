using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Hello__Name_
{
    class hello
    {
        static string GetName(string name)
        {
            Console.WriteLine($"Hello, {name}!");
            return name;
        }
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            GetName(name);
        }
    }
}
