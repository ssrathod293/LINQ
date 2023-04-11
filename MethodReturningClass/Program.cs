using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodReturningClass
{
    class Program
    {
        static void Main(string[] args)
        {
            UserDefinedEmp usr = new UserDefinedEmp();
           EMP res= usr.GetDetails(108);
            Console.WriteLine($"Eno:{res.Eno} EName:{res.Ename} Job:{res.job} Salary:{res.salary} Status:{res.status}");
            Console.ReadLine();
        }
    }
    public class EMP
    {
        public int Eno;
        public string Ename,job;
        public double salary;
        public bool status;
    }
    public class UserDefinedEmp
    {
        public EMP GetDetails(int Eno)
        {
            EMP e = new EMP();
            e.Eno = Eno;
            e.Ename = "Shrikant";
            e.job = "Engg";
            e.salary = 25000.00;
            e.status = true;
            return e;
        }
    }
}
