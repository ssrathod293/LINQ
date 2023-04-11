using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoinsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Trainer t1 = new Trainer() { TrainerId = 1, TrainerName = "vikul", Experience = 13 };
            Trainer t2 = new Trainer() { TrainerId = 2, TrainerName = "Usha", Experience = 1 };
            Trainer t3 = new Trainer() { TrainerId = 3, TrainerName = "Atul", Experience = 2 };

            List<Trainer> trainers = new List<Trainer>() { t1, t2, t3 };


            Student s1 = new Student() { RollNumber = 11, Name = "shrikant", Gender = "male", Age = 30, TrainerId = 1,CourseId=1 };
            Student s2 = new Student() { RollNumber = 23, Name = "jaypal", Gender = "male", Age = 24, TrainerId = 1,CourseId=null };
            Student s3 = new Student() { RollNumber = 12, Name = "jayshree", Gender = "female", Age = 29, TrainerId = null ,CourseId=3};
            Student s4 = new Student() { RollNumber = 16, Name = "akshita", Gender = "female", Age = 21, TrainerId = 2,CourseId=2 };
            Student s5 = new Student() { RollNumber = 17, Name = "bunty", Gender = "male", Age = 20, TrainerId = null,CourseId=null };

            List<Student> students = new List<Student>() { s1, s2, s3, s4, s5 };
            Console.WriteLine("***********************ALL TRAINER*************************************");
            foreach (var item in trainers)
            {
                Console.WriteLine($"TrainerId:{item.TrainerId} Name:{item.TrainerName} Experience:{item.Experience} ");

            }
            Console.WriteLine("*****************************ALL STUDENTS*************************************************");
            foreach (var item in students)
            {
                Console.WriteLine($"RollNumber:{item.RollNumber} Name:{item.Name} Gender:{item.Gender} Age:{item.Age} TrainerId{item.TrainerId} CourseId{item.CourseId}");

            }
            List<Course> courses = new List<Course>()
            {
             new Course(){CourseId=1,CourseName="DOT NET"},
             new Course(){CourseId=2,CourseName="TESTING"},
             new Course(){CourseId=3,CourseName="Python"}

            };
            Console.WriteLine("***************ALL COURSES******************************");
            foreach (var item in courses)
            {
                Console.WriteLine($"CourseId:{item.CourseId} CourseName:{item.CourseName}");

            }
            /*
            //Join()--inner join result
            //in sql
            //select s.StudentName,t.TrainerName
            //from student s join trainer t
            //on s.trainerId=t.trainerId
            var result = students.Join(trainers, s => s.TrainerId, t => t.TrainerId,
                 (s, t) => new { StudentName = s.Name, TrainerName = t.TrainerId }
                 );
            Console.WriteLine("**************INNER JOIN**********************");
            foreach (var item in result)
            {
                Console.WriteLine($"{item.StudentName}:{item.TrainerName}");
            }

            //Join()--inner join result
            //in sql
            //select s.StudentName,t.TrainerName
            //from student s left join trainer t
            //on s.trainerId=t.trainerId

          var result1 = students.GroupJoin(trainers, s => s.TrainerId, t => t.TrainerId,
                (s, tc) => new
                {
                    StudentName = s.Name,
                    TrainerName = tc.FirstOrDefault(t => t.TrainerId == s.TrainerId)?.TrainerName
                }
            );
            Console.WriteLine("**************left JOIN**********************");
            foreach (var item in result1)
            {
                Console.WriteLine($"{item.StudentName}:{item.TrainerName}");
            }
            */
            #region join using sqlQuery syntax
            //var result = from s in students
            //             join t in trainers
            //             on s.TrainerId equals t.TrainerId
            //             select new { StudentName = s.Name, TrainerName = t.TrainerName };
            //Console.WriteLine("*****************INNER JOIN*****************************");
            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.StudentName}--{item.TrainerName}");
            //}
            //Console.WriteLine("*********************LEFT JOIN******************************");
            ////left join
            //var result1 = from s in students
            //              join t in trainers
            //              on s.TrainerId equals t.TrainerId
            //              into allStudents
            //              from st in allStudents.DefaultIfEmpty()
            //              select new { StudentName = s.Name, TrainerName = st?.TrainerName };

            //foreach (var item in result1)
            //{
            //    Console.WriteLine($"{item.StudentName}--{item.TrainerName}");
            //}


            ////right join
            //Console.WriteLine("********************RIGHT JOIN*************************");
            //var result3 = from t in trainers
            //              join s in students
            //              on t.TrainerId equals s.TrainerId
            //              into allTrainers
            //              from at in allTrainers.DefaultIfEmpty()
            //              select new { StudentName = at?.Name, TrainerName = t.TrainerName };

            //foreach (var item in result3)
            //{
            //    Console.WriteLine($"{item.StudentName}--{item.TrainerName}");
            //}

            ////full join
            //Console.WriteLine("****************FULL JOIN***************************");
            //var result4 = result1.Union(result3);
            //foreach (var item in result4)
            //{
            //    Console.WriteLine($"{item.StudentName}--{item.TrainerName}");
            //}

            ////cross join
            //Console.WriteLine("********************CROSS JOIN***************************************");
            //var result5 = from s in students
            //              from t in trainers
            //              select new { StudentName = s.Name, TrainerName = t.TrainerName };

            //foreach (var item in result5)
            //{
            //    Console.WriteLine($"{item.StudentName}--{item.TrainerName}");
            //}

            #endregion
            Console.WriteLine("*******************join************************");
            var result = from s in students
                         join t in trainers
                         on s.CourseId equals t.TrainerId
                         select new {StudentName=s.Name,TrainerName=t.TrainerName };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.StudentName}--{item.TrainerName}");
            }

            Console.WriteLine("*******************join 3 tables************************");
            var result1 = from s in students
                         join t in trainers
                         on s.CourseId equals t.TrainerId
                         join c in courses
                         on s.CourseId equals c.CourseId
                         select new { StudentName = s.Name, TrainerName = t.TrainerName,CourseName=c.CourseName };
            foreach (var item in result1)
            {
                Console.WriteLine($"{item.StudentName}--{item.TrainerName}--{item.CourseName}");
            }
            Console.ReadLine();
        }
    }

    public class Trainer
    {
        public int TrainerId { get; set; }
        public string TrainerName { get; set; }
        public int Experience { get; set; }
    }

    public class Student
    {

        public int RollNumber { get; set; }
        public string Name { get; set; }
        public string Gender { get; set; }
        public int Age { get; set; }

        public int? TrainerId { get; set; }
        public int? CourseId { get; set; }
    }

    public class Course
    {
        public int CourseId { get; set; }
        public string CourseName { get; set; }
    }
}
