using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyNetApp
{
    internal class ReturnEvenorodd
    {
    }

    public class test
    {
        public static void Main(string[] args)
        {
            List<int> number = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8 };
            IEnumerable<int> result = number.Where(x => x % 2 == 1);

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
