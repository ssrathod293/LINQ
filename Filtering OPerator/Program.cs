using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Filtering_OPerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { RollNumber=11,Name="shrikant",Gender="male",Age=30};
            Student s2 = new Student() { RollNumber=23,Name="jaypal",Gender="male",Age=24};
            Student s3 = new Student() { RollNumber=12,Name="jayshree",Gender="female",Age=29};
            Student s4 = new Student() { RollNumber=16,Name="akshita",Gender="female",Age=21};
            Student s5 = new Student() { RollNumber=17,Name="bunty",Gender="male",Age=20};

            List<Student> student = new List<Student>() {s1,s2,s3,s4,s5 };
            foreach (var item in student)
            {
                Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");
            }

            //all male students
            Console.WriteLine("--------------------all male students------------------------");
           IEnumerable<Student>result =student.Where(s=>s.Gender.Equals("male"));
            foreach (var item in result)
            {
                Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");
            }
            ///////////////////////////////////////////////////////////////////////////////////////////
            Console.WriteLine("------------------------all female students----------------------------------------------------");
            var result2 = from s in student
                          where s.Gender.Equals("female")
                          select s;
            foreach (var item in result2)
            {
                Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");
            }
            ///////////////////////////gettype or oftype()
            List<object> items = new List<object>() { 10,20,15,'A','$',"shri","jayu"};
            foreach (var item in items)
            {
                Console.Write(item+" ");
            }
            Console.WriteLine();
            // var result3=items.Where(o=>o.GetType().Name=="String");
            //var result3=items.OfType<int>();
            var result3=items.OfType<String>();
            foreach (var item in result3)
            {
                Console.WriteLine(item);
            }

            List<car> cars = new List<car>() { new car(),new BMW(),new AUDI()};
            foreach (var item in cars)
            {
                Console.Write(item.Name+" ");
            }
            Console.WriteLine("---------------------------------------------------------");
            var res=cars.OfType<BMW>();
            foreach (var item in res)
            {
                Console.WriteLine(item.Name);
            }
            Console.ReadLine();
        }
        public class Student
        {
            public int RollNumber { get; set; }
            public string Name{ get; set; }
            public string Gender { get; set; }
            public int Age { get; set; }
        }
        public class car
        {
            public string Name { get; set; }
            public car()
            {
                Name = "Normal";
            }

        }
        public class BMW : car
        {
            public BMW()
            {
                Name = "BMW";
            }
        }
        public class AUDI : car
        {
            public AUDI()
            {
                Name = "AUDI";
            }
        }
    }
}
