using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComparisonMergeOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers1 = new List<int>() { 1, 2, 3 };
            List<int> numbers2 = new List<int>() {3,1,2 };

            numbers1.Sort();
            numbers2.Sort();
            if (numbers1.SequenceEqual(numbers2))
            {
                Console.WriteLine("collections are equal");
            }
            else
            {
                Console.WriteLine("collection are not equal");
            }
            List<string> names1 = new List<string>() {"first","second","third" };
            List<string> names2 = new List<string>() { "fourth","fifth","third"};
            IEnumerable<string>result=names1.Concat(names2);
            foreach (var item in result)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
            IEnumerable<string> result1 = names1.Union(names2);
            foreach (var item in result1)
            {
                Console.Write(item +" ");
            }
            Console.WriteLine();
            IEnumerable<string> result3 = names1.Intersect(names2);
            foreach (var item in result3)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            IEnumerable<string> result4 = names1.Except(names2);
            foreach (var item in result4)
            {
                Console.Write(item);
            }
            Console.WriteLine();
            List<string> names = new List<string>() { "bunty", "balaji", "bunty", "shri", "balaji", "shri", "jayu", "shrikant" };
            foreach (var item in names)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            IEnumerable<string>name1=names.Distinct();
            foreach (var item in name1)
            {
                Console.Write(item+" ");
            }
            Console.ReadLine();
        }
    }
}
