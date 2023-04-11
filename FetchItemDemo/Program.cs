using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FetchItemDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 2,4,8,70,45,67,89};

            Console.WriteLine("***********ALL ITEMS***************");
            foreach (var item in numbers)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            IEnumerable<int>count=numbers.Take(2);
           
            foreach (var item in count)
            {
                Console.Write(item + " ");
            }
            Console.WriteLine();
            //take()--returns number of item given
           IEnumerable<int>count2= numbers.Skip(3);
            foreach (var item in count2)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            Console.WriteLine("*************takewhile()***********************");
            IEnumerable<int> result=numbers.TakeWhile(i => i < 10);
            foreach (var item in result)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("**********skipwhile()*****************");
            //skipwhile()--skip items till condition is true remaining
           //IEnumerable<int>result5=numbers.SkipWhile(i=>i<10);
           IEnumerable<int>result5=numbers.SkipWhile(i=>i>10);
            //skipwhile() checks for first item if false then return all values
            foreach (var item in result5)
            {
                Console.Write(item+" ");
            }

            Console.ReadLine();
        }

    }
}
