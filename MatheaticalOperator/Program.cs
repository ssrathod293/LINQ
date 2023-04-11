using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatheaticalOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("********ALL ITMES**************");
            foreach (var item in numbers)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            double r1 = numbers.Min();
            Console.WriteLine("min:"+r1);

            r1 = numbers.Max();
            Console.WriteLine("max:" + r1);

            r1 = numbers.Sum();
            Console.WriteLine("sum:" + r1);

            r1 = numbers.Count();
            Console.WriteLine("count():" + r1);

            r1 = numbers.Count(i=>i%2==0);
            Console.WriteLine("count():" + r1);


            Console.ReadLine();
        }
    }
}
