using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElementsOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> { 2, 4, 5, 8, 7 ,9,21,34,21,22};
            //elementsAt()--fetch element from index
            int i = numbers.ElementAt(0);
            Console.WriteLine(i);
            i = numbers.ElementAt(3);
            Console.WriteLine(i);

            //it will throw the exception index out of range
            //to handle the exception us ElementsAtOrDefault()
            //if exception occur it will return default valur

            // i = numbers.ElementAt(30);
            i = numbers.ElementAtOrDefault(20);
            Console.WriteLine(i);
            Console.WriteLine("*************all items*******************");
            foreach (var item in numbers)
            {
                Console.Write(item +" ");
            }
            i = numbers.First();
            Console.WriteLine(i);
            i = numbers.First(i1=>i1>5);
            Console.WriteLine(i);

            //first()--throws exception if there is no matching item
            //it handles by firstOrDefault() method and returns default

            //i = numbers.First(i1 => i1 > 500);
            i = numbers.FirstOrDefault(i1 => i1 > 500);
            Console.WriteLine(i);

            //last()----------returns last
            i = numbers.Last();
            Console.WriteLine(i);
            i = numbers.Last(i1 => i1 > 5);
            Console.WriteLine(i);

            //first()--throws exception if there is no matching item
            //it handles by firstOrDefault() method and returns default

            //i = numbers.Last(i1 => i1 > 500);
            i = numbers.LastOrDefault(i1 => i1 > 500);
            Console.WriteLine(i);

            //single()--returns matching item
            //it should have only one matching item in collection

            List<int> numbers1 = new List<int> { 2 };
            int i2 = numbers1.Single();
            List<int> numbers2 = new List<int> { 2, 4, 5, 8, 7};
            i2 = numbers2.Single(i3=>i3>7);
          

            Console.WriteLine(i2);
            i2 = numbers2.SingleOrDefault(i3 => i3 > 70);

            //singleOrDefault--handles exception only if there is no matching item
            //note:does not handles exception if there are multiple items
            Console.WriteLine(i2);

            for (int j = 0; j < numbers.Count; j++)
            {
                Console.WriteLine(numbers.ElementAt(j));
            }
            Console.ReadLine();

        }
    }
}
