﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Strings_and_Objects
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello";
            string world = "World";
            object greating = hello + " " + world;
            string castGreating = Convert.ToString(greating);
            Console.WriteLine(castGreating);
        }
    }
}
