using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.LogsAggregator
{
    class Program
    {
        static void Main(string[] args)
        {
            var loginDetails = new SortedDictionary<string, Dictionary<string, int>>();
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {
                string input = Console.ReadLine();
                var inputArgs = input
                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToList();

                string ipAdress = inputArgs[0];
                string userName = inputArgs[1];
                int duration = int.Parse(inputArgs[2]);

                if (!loginDetails.ContainsKey(userName))
                {
                    loginDetails.Add(userName, new Dictionary<string, int>());
                }

                if (!loginDetails[userName].ContainsKey(ipAdress))
                {
                    loginDetails[userName].Add(ipAdress, 0);
                }
                loginDetails[userName][ipAdress] += duration;
            }

            foreach (var user in loginDetails)
            {
                HashSet<string> ip = new HashSet<string>();
                var time = user.Value.Values.Sum();
                foreach (var item in loginDetails[user.Key])
                {
                    ip.Add($"{item.Key}");
                }
                Console.WriteLine($"{user.Key}: {time} [{String.Join(", ", ip.OrderBy(x => x))}]");
            }
        }
    }
}
