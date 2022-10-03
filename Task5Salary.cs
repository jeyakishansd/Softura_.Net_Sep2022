using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace KonsoleApp
{
    abstract class Detials
    {
        abstract public void empID(string ID);
        abstract public void empName(string Name,string deptName);
        abstract public void gender(string gender);
        abstract public void yearsOfExperience(int year);
        abstract public void salary(int salary);

    }
    class Sales : Detials
    {
        public void bonussal(int salary)
        {
            double bonus = salary * 0.2;
            Console.WriteLine("Bonus is :{0}", bonus);
            Console.WriteLine("Total salary of sales dept employee is {0}", bonus + salary);
        }
        public override void empID(string ID)
        {
            Console.WriteLine("Employee ID is {0}", ID);
        }
        public override void empName(string Name, string deptName)
        {
            Console.WriteLine("Employee name is {0} from {1} department", Name, deptName);
        }
        public override void gender(string gender)
        {
            Console.WriteLine("Gender :{0}", gender);
        }
        public override void yearsOfExperience(int year)
        {
            Console.WriteLine("Years of experience :{0}", year);
        }
        public override void salary(int salary)
        {
            Console.WriteLine("salary : {0}", salary);
        }
    }
        class marketing : Sales
        {
            public void bonusmar(int salary)
            {
                double bonus = salary * 0.2;
                Console.WriteLine("Bonus is {0}", bonus);
                Console.WriteLine("Total salary is {0}", bonus + salary);
        }
    }
    class production : Sales
    {
        public  void bonuspro(int salary)
        {
            double bonus = salary * 0.1;
            Console.WriteLine("Bonus is {0}",bonus);
            Console.WriteLine("salary is {0}",bonus + salary);
        }
    }
    internal class Task6Salary
    {
        public static void Main()
        {
            Sales sal = new Sales();
            sal.empID("36");
            sal.empName("Jeyakishan", "Sales");
            sal.gender("Male");
            sal.yearsOfExperience(2);
            sal.salary(45000);
            sal.bonussal(45000);
            Console.WriteLine("---------------------------------------------");
            marketing mar = new marketing();
            mar.empID("46");
            mar.empName("Kishan", "marketing");
            mar.gender("Male");
            mar.yearsOfExperience(3);
            mar.salary(34000);
            mar.bonusmar(34000);
            Console.WriteLine("---------------------------------------------");
            production prod = new production();
            prod.empID("23");
            prod.empName("Jey", "Production");
            prod.gender("Male");
            prod.yearsOfExperience(6);
            prod.salary(67000);
            prod.bonuspro(67000);

        }
    }
}
