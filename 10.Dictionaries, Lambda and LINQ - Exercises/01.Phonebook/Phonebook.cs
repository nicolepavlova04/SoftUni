using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Phonebook
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> phonebook = new Dictionary<string, string>();
            var commandLine = Console.ReadLine();

            while (! commandLine.Equals("END"))
            {
                string[] commandArgs = commandLine.Split(' ');
                string command = commandArgs[0];

                if (command.Equals("A"))
                {
                    string name = commandArgs[1];
                    string number = commandArgs[2];
                    phonebook[name] = number;
                }
                else if (command.Equals("S"))
                {
                    string name = commandArgs[1];
                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine("{0} -> {1}", name, phonebook[name]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist.", name);
                    }
                } 
                commandLine = Console.ReadLine();
            }
        }
    }
}
