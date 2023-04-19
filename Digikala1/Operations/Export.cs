using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Digikala1.Operations
{
    class Export
    {
        public static void Run()
        {
            string address = @"D:\digikala dataset\orders.csv";
            List<string> cities = new List<string>();

            using (StreamReader srreader = new StreamReader(address))
            {
                while (!srreader.EndOfStream)
                {
                    string line = srreader.ReadLine();
                    string city = Regex.Replace(line, @"(\d|\.|,|:|-| )+", ""); 
                    cities.Add(city);
                }
            }

            var nonduplicateCities = cities.Distinct();

            foreach (string city in nonduplicateCities)
            {
                using (StreamWriter strwriter = new StreamWriter($@"D:\{city}.csv"))
                {
                    strwriter.WriteLine($"City: {city}"); 
                }
            }
        }
    }
}
