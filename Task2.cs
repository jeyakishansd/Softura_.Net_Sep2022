using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task2
    {
        public static void Main()
        {
            Console.WriteLine("Enter Your Name");
            String name=Console.ReadLine();
            Console.WriteLine("Enter Your age" );
            int age=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=age;i++)
                Console.WriteLine(name);
        }
    }
}
