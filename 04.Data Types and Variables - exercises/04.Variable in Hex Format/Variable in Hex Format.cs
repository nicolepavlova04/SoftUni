﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Variable_in_Hex_Format
{
    class Program
    {
        static void Main(string[] args)
        {
            string n1 = Console.ReadLine();
            Console.WriteLine(Convert.ToInt16(n1, 16));

        }
    }
}
