using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuantifiersDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int> {1,2,3,4,5,6,7,8,9 };
            bool b1 = numbers.Contains(2);
            Console.WriteLine(b1);//true

            b1 = numbers.Contains(20);
            Console.WriteLine(b1);//false

            b1 = numbers.Any(i=>i>5);
            Console.WriteLine(b1);//true

            b1 = numbers.Any(i => i > 50);
            Console.WriteLine(b1);//false

            b1 = numbers.All(i => i > 5);
            Console.WriteLine(b1);//false

            b1 = numbers.Any(i => i > 0);
            Console.WriteLine(b1);//true
        ////////////////////////////////////////////////////////////////////////////////////////////////////////
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
            Student s6 = new Student() { RollNumber = 17, Name = "bunty", Gender = "male", Age = 20 };
            bool b2=students.Contains(s6,new StudentHelper());
            Console.WriteLine(b2);

            Console.ReadLine();
        }
    }
    public class Student
    {
        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        //public override bool Equals(object obj)
        //{
        //    Student s = obj as Student;
        //    return this.RollNumber.Equals(RollNumber) &&
        //        this.Name.Equals(Name) && this.Gender.Equals(Gender) &&
        //        this.Age.Equals(Age);
        //}
    }
    public class StudentHelper : IEqualityComparer<Student>
    {
        public bool Equals(Student x, Student y)
        {
            return x.RollNumber.Equals(y.RollNumber) &&
                x.Name.Equals(y.Name) && x.Gender.Equals(y.Gender) && x.Age.Equals(y.Age);
        }

        public int GetHashCode(Student obj)
        {
            return obj.RollNumber.GetHashCode() ^ obj.Name.GetHashCode() ^ obj.Gender.GetHashCode()
                ^ obj.Age.GetHashCode();
        }
    }
}
