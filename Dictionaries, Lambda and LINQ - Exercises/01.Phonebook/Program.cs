using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01.Phonebook
{
    class Program
    {
        static void Main(string[] args)
        {
            var phonebook = new Dictionary<string, string>();
            string input = Console.ReadLine();

            while (input != "END")
            {
                var commandArgs = input.Split(' ').ToList();
                string command = commandArgs[0];

                if (command == "A")
                {
                    string name = commandArgs[1];
                    string telephone = commandArgs[2];

                    if (!phonebook.ContainsKey(name))
                    {
                        phonebook.Add(name, telephone);
                    }
                    else
                    {
                        phonebook[name] = telephone;
                    }
                }
                else
                {
                    string name = commandArgs[1];

                    if (phonebook.ContainsKey(name))
                    {
                        Console.WriteLine($"{name} -> {phonebook[name]}");
                    }
                    else
                    {
                        Console.WriteLine($"Contact {name} does not exist.");
                    }
                }
                input = Console.ReadLine();
            }
        }
    }
}
