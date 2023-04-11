using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Naresh_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            /////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            /////////////////////////////////program for addition of array and addiion of even element in array//////////////////////////////
            /*
            int sum = 0;
            int[] num = new int[] { 10,23,45,5,87,12,34,65,24};
            foreach (var item in num)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < num.Length; i++)
            {
                sum += num[i];
            }
            Console.WriteLine($"addition is:{sum}");
            sum = 0;
            for (int i = 0; i < num.Length; i++)
            {
                if(num[i]%2==0)
                sum += num[i];
            }
            Console.WriteLine($"addition of even num is:{sum}");
            */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////program to remove duplicate word from array//////////////////////////////////////////////////////////////
            //code to remove foo "foo bar foo $ bar $ foo bar $" 
            /* string str = "foo bar foo $ bar $ foo bar";
             var sentance = String.Join(" ",str.Split(' ').Distinct());
             Console.WriteLine(sentance);*/

            ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            ///////////////////////////program to remove particular word from the array///////////////////////////////////
            /*
            string str1 = "foo bar foo $ bar $ foo bar";
            string[] sen=str1.Split(' ');
            
            for (int i = 0; i < sen.Length; i++)
            {
              
                if (!sen[i].Contains("foo"))
                {
                    
                    Console.Write(sen[i]+" ");
                }
             
            }*/
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////add two numbers without Plus operator////////////////////////
            /*   
               int x = add(20,30);
               Console.WriteLine(x);
               int y = binaryadd(5,4);
               Console.WriteLine(y);
               Console.ReadLine(); 
           }
           static int add(int x,int y)
           {
               for (int i = 1; i < y; i++)
               {
                   x++;
               }
               return x;
           }

                static int binaryadd(int x, int y)
        {
            while (x != 0)
            {
                int c = y & x;
                y = y ^ x;
                x = c << 1;
            }
            return y;
        }
             */
            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //////////////////////////////////////////////////swap two numbers without 3rd variable////////////////////////
            /*  //x=20,y=10 x=x+y=30
            //y=x-y=20
            //x=x-y=10

            //x=10,y=5 x= x*y=50
            //y=x/y=10
            //x=x/y=5

            int x = 10, y = 5;
            Console.WriteLine($" before swapping=>X:{x} y:{y}");

            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine($" after swapping=>X:{x} y:{y}");*/
            Console.ReadLine();

        }
    
    }
}
