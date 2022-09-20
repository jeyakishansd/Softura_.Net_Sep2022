using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;
using System.Reflection;

namespace KonsoleApp
{
    [Serializable()]
    public class Employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string gender { get; set; }
    }
    internal class Task6Serialization
    {
        public static void Main()
        {
            Employee emp = new Employee()
            {
                id = 36,
                name = "jey",
                age = 22,
                gender = "male"
            };
            BinaryFormatter bf = new BinaryFormatter();
            Stream s = new FileStream("Taskemployee.txt", FileMode.Create, FileAccess.Write, FileShare.None);
            bf.Serialize(s, emp);
            s.Close();

            FileStream fs1 = new FileStream("Taskemployee.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryFormatter bf1 = new BinaryFormatter();

            Employee emp2 = (Employee)bf1.Deserialize(fs1);
            Console.WriteLine("Employee Details ");
            Console.WriteLine(emp2.id);
            Console.WriteLine(emp2.name);
            Console.WriteLine(emp2.age);
            Console.WriteLine(emp2.gender);
            fs1.Close();

        }
    }
}
