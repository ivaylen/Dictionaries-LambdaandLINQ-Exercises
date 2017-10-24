using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.AMinerTask
{
    class Program
    {
        static void Main(string[] args)
        {
            var resources = new Dictionary<string, double>();
            string input;

            while((input = Console.ReadLine()) != "stop")
            {
                if (resources.ContainsKey(input))
                {
                    resources[input] += double.Parse(Console.ReadLine());
                }
                else
                {
                    resources[input] = double.Parse(Console.ReadLine());
                }
            }

            foreach (var item in resources)
            {
                Console.WriteLine("{0} -> {1}", item.Key, item.Value);
            }
        }
    }
}
