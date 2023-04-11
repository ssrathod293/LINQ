using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LambadaExpDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> d1 = s => Console.WriteLine(s.ToUpper());
            d1("Vishal");
            Predicate<int> d2 = i => i % 2 == 0;
            Console.WriteLine(d2(22));
            Console.WriteLine(d2(15));

            Func<int, int, int> d3 = (a, b) => a + b;
            Console.WriteLine(d3(12,23));

            //we can write multiple line like a method
            Func<int, int, int> d4 = (a, b) =>
            {
                int c = a + b;
                return c;
            };

            Console.WriteLine(d4(12,45));

            Console.ReadLine();
        }
    }
}
