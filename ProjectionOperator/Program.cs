using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectionOperator
{
    class Program
    {
        //projection operator--to format data
        static void Main(string[] args)
        {
            Student s1 = new Student() { RollNumber = 11, Name = "shrikant", Gender = "male", Age = 30,subjects=new List<string>() { "s1","s2"} };
            Student s2 = new Student() { RollNumber = 23, Name = "jaypal", Gender = "male", Age = 24 ,subjects=new List<string>() {"s3" } };
            Student s3 = new Student() { RollNumber = 12, Name = "jayshree", Gender = "female", Age = 29 ,subjects=new List<string>() { "s4","s5"} };
            Student s4 = new Student() { RollNumber = 16, Name = "akshita", Gender = "female", Age = 21,subjects=new List<string>() { "s6"} };
            Student s5 = new Student() { RollNumber = 17, Name = "bunty", Gender = "male", Age = 20,subjects=new List<string>() { "s7","s8"} };

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };
            foreach (var item in students)
            {
                Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");
            }
            //student collection as string collection --why??
            //we want only student
            //using linquery
            var result1 = from s in students
                          select s.Name;
            Console.WriteLine("all student names");
            foreach (var item in result1)
            {
                Console.Write(item+" ");
            }
           IEnumerable<int>result2= students.Select(s=>s.Age);
            foreach (var item in result2)
            {
                Console.Write(item);
            }

           
            var result3 = students.Select(s=>new { Name=s.Name,Gender=s.Gender});
           
         Console.WriteLine("***********ALL NAME AND GENDER****************");
            foreach (var item in result3)
            {
                Console.WriteLine($"{item.Name}--{item.Gender}");
            }

            // I have student list I want to project it as a employee list

           var result4= students.Select(s => new Employee
            {

                EmpId = s.RollNumber,
                Name = s.Name,
                Gender = s.Gender,
                Age = s.Age
            }); ;

            foreach (var item in result4)
            {
                Console.WriteLine($"EmpId:{item.EmpId} Name:{item.Name} Gender:{item.Gender} Age:{item.Age}");
            }

            //we want to project all subjects
            //IEnumerable<List<string>> sub  =students.Select(s=>s.subjects);
            // foreach (var items in sub)
            // {
            //     foreach (var item in items)
            //     {
            //         Console.Write(item+" ");
            //     }
            // }

            //if want project collection of collection use select many
           IEnumerable<string> subjects= students.SelectMany(s=>s.subjects);
            foreach (var item in subjects)
            {
                Console.Write(item+" ");
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
            public List<string> subjects { get; set; }

    }
    public class Employee
    {

        public int EmpId { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

    }
}

