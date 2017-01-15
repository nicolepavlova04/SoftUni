using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04.Fix_Emails
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, string> contacts = new Dictionary<string, string>();
            string input = Console.ReadLine();
            while (input != "stop")
            {
                string email = Console.ReadLine();
                string emailDomain = email.Substring(email.Length - 2);
                
               if(!emailDomain.Equals("uk") && !emailDomain.Equals("us"))
                {
                    contacts[input] = email;
                }
                input = Console.ReadLine();
            }
            
                
            
            foreach (string key in contacts.Keys)
            {
                Console.WriteLine($"{key} -> {contacts[key]}");
            }
        }
    }
}
