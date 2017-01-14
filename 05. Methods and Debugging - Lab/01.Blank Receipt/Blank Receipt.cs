﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Blank_Receipt
{
    class Program
    {
        static void PrintReceiptHeader()
        {
            Console.WriteLine("CASH RECEIPT");
            Console.WriteLine(new string('-', 30));
        }
        static void PrintReceiptBody()
        {
            Console.WriteLine("Charged to" + new string('_', 20));
            Console.WriteLine("Received by" + new string('_', 19));
        }
        static void PrintReceiptFooter()
        {
            Console.WriteLine(new string('-', 30));

            Console.WriteLine("\u00A9 SoftUni");
        }
        static void Main(string[] args)
        {
            PrintReceiptHeader();
            PrintReceiptBody();
            PrintReceiptFooter();
        }
    }
}

