using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GroupingOperatorDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Student s1 = new Student() { RollNumber = 11, Name = "shrikant", Gender = "male", Age = 30  };
            Student s2 = new Student() { RollNumber = 23, Name = "jaypal", Gender = "male", Age = 24};
            Student s3 = new Student() { RollNumber = 12, Name = "jayshree", Gender = "female", Age = 29};
            Student s4 = new Student() { RollNumber = 16, Name = "akshita", Gender = "female", Age = 21};
            Student s5 = new Student() { RollNumber = 17, Name = "bunty", Gender = "male", Age = 20};

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };
            foreach (var item in students)
            {
                Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");
            }

            //var groups =students.GroupBy(s=>s.Gender);
            //groupBy support query syntax
            var groups = from s in students
                         group s by s.Gender;
          // var groups =students.ToLookup(s=>s.Gender);
          //ToLookup does not support query syntax
            foreach (var item in groups)
            {
                Console.WriteLine($"key:{item.Key}");
                Console.WriteLine($"key:{item.Count()}");
                foreach (var s in item)
                {
                    Console.WriteLine($"{s.Name}");
                }
            }


            Console.ReadLine();
        }
    }
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }        
    }
}
