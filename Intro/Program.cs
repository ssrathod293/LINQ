using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>() { "shrikat","shrinee","jayshree","jaypal","akshita","balaji"};
            foreach (var item in names)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();

            //without linq
            /* List<string> names1 = new List<string>();
             foreach (var item in names)
             {
                 if (item.StartsWith("j"))
                 {
                     names1.Add(item);
                 }
             }
             Console.WriteLine();*/
            //using linq
            /*
            var names1 = from item in names
                         where item.StartsWith("j")
                         select item;
                   */
            //using method syntax
            /* Func<string, bool> del = delegate (string s)
                 {
                     return s.StartsWith("j");
                 };
             IEnumerable<string>names1=names.Where(del);*/
            /*
            IEnumerable<string> names1 = names.Where(delegate (string item)
            {
                return item.StartsWith("j");
            });*/

            IEnumerable<string> names1 = names.Where(item=>item.StartsWith("j")); 

           Console.WriteLine("---------------------------names start with j   ----------------------");
            foreach (var item in names1)
            {
                Console.Write(item +" ");
            }

            Console.ReadLine();
        }
    }
}
