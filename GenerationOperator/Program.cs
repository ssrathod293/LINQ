using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerationOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //string s="vishal";
            //string s="";
            //string s=null;
            //string s=string.empty;
            List<int> number1 = new List<int>();
            Console.WriteLine(number1.Count);

            IEnumerable<int> number2=number1.DefaultIfEmpty<int>();
            Console.WriteLine(number2.Count());
            foreach (var item in number2)
            {
                Console.WriteLine(item);
            }
            IEnumerable<string>names1=Enumerable.Empty<string>();
            Console.WriteLine(names1.Count());

            var numbers=Enumerable.Repeat<int>(10,20);
            Console.WriteLine(numbers.Count());
            foreach (var item in numbers)
            {
                Console.Write(item+" ");
            }

            IEnumerable<int> numbers2=Enumerable.Range(1,100);
            Console.WriteLine(number2.Count());
            foreach (var item in numbers2)
            {
                Console.Write(item+",");
            }


            Console.ReadLine();
        }
    }
}
