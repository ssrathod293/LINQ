using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConversionOPerators
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names1 = new List<string>() { "suraj", "sai", "shubham" };
            //string[] names2 = names1.ToArray();

            //Dictionary<string, string> names3 = names1.ToDictionary(s=>s);
            //List<KeyValuePair<string, string>> names4 = names3.ToList();

            //all names contains "U"
          var result=  names1.Where(s=>s.Contains("u"));//deferrred
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }

            var result1 = names1.Where(s => s.Contains("u")).ToList();//eager
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
           
            Console.ReadLine();
        }
    }
}
