using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNetApp
{
    internal class distinctcountries
    {

    }
    public class Dcountries
    {
        public static void Main(string[] args)
        {
            List<string> countries = new List<string> {"India","Singapore","US", "India", "Singapore", "US" };
            IEnumerable<string> distinctcountries = (from n in countries
                                                    select n).Distinct();

            foreach (var item in distinctcountries)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
