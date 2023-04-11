using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderigOperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple collection
            //List<int> numbers = new List<int>() { 2, 4, 6, 5, 8, 9, 18, 23 };
            //Console.WriteLine("********ALL ITEMS**********");
            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            ////numbers.Reverse();
            ////Console.WriteLine("********ALL ITEMS after reverse**********");
            ////foreach (var item in numbers)
            ////{
            ////    Console.Write(item + " ");
            ////}
            ////Console.WriteLine();
            //var result = numbers.OrderBy(i => i);//asending order
            //Console.WriteLine("********ALL ITEMS after orderby**********");
            //foreach (var item in result)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //var result1 = numbers.OrderByDescending(i => i);//asending order
            //Console.WriteLine("********ALL ITEMS after orderby**********");
            //foreach (var item in result1)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            //numbers.Sort();
            //numbers.Reverse();
            //Console.WriteLine("********ALL ITEMS after sort**********");
            //foreach (var item in numbers)
            //{
            //    Console.Write(item + " ");
            //}
            //Console.WriteLine();
            #endregion
            Student s1 = new Student() { RollNumber = 11, Name = "shrikant", Gender = "male", Age = 30 };
            Student s2 = new Student() { RollNumber = 23, Name = "jaypal", Gender = "male", Age = 24 };
            Student s3 = new Student() { RollNumber = 12, Name = "jayshree", Gender = "female", Age = 29 };
            Student s4 = new Student() { RollNumber = 16, Name = "akshita", Gender = "female", Age = 21 };
            Student s5 = new Student() { RollNumber = 17, Name = "bunty", Gender = "male", Age = 20 };

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };
            foreach (var item in students)
            {
                Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");
                
            }
            Console.WriteLine("******************orderby**********************");

            ////IOrderedEnumerable<Student> result1 =students.OrderBy(s=>s.Gender);
            //IOrderedEnumerable<Student> result1 =students.OrderByDescending(s=>s.Gender);
            // foreach (var item in result1)
            // {
            //     Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");

            // }


            //IOrderedEnumerable<Student> result1 =students.OrderBy(s=>s.Gender).ThenBy(s=>s.Name);
            ////IOrderedEnumerable<Student> result1 = students.OrderByDescending(s => s.Gender);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");

            //}

            //IOrderedEnumerable<Student> result1 = students.OrderBy(s => s.Gender).ThenByDescending(s => s.Name);
            ////IOrderedEnumerable<Student> result1 = students.OrderByDescending(s => s.Gender);
            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");

            //}
            //in sql-select* from student order by gender,name
            //in sql-select* from student order by gender desc

            //students.Sort();--1st overload
            //has 4 overloads throws exception complex type
            //sort()--sort(Icomparer)--sort(index,count,Icomparer)--sort(IComparison)

            //students.Sort(new studentHelper());// 2nd overload

            //students.Sort(0,3,new studentHelper());//3rd overload from 0 to 3 items
            //Comparison<Student>

            students.Sort((x,y)=>x.Age.CompareTo(y.Age));
            Console.WriteLine("ALL STUDENTS AFTER SORT()");
            foreach (var item in students)
            {
                Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");

            }


            Console.ReadLine();
        }

        public class Student:IComparable
        {

            public int RollNumber { get; set; }
            public string Name { get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }

            public int CompareTo(object obj)
            {
                Student s = obj as Student;
                //if (this.Age > s.Age) return 1;
                //else if (this.Age < s.Age) return -1;
                //else  return 0;
                return this.Age.CompareTo(s.Age);
            }
        }

        public class studentHelper : IComparer<Student>
        {
            public int Compare(Student x, Student y)
            {
                //name sort
                return x.Name.CompareTo(y.Name);
            }
        }
    }
}
