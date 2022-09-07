using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Taskk2
    {
        public static void Main()
        {
            Console.WriteLine("Enter the number");
            int num=Convert.ToInt32(Console.ReadLine());
            for(int i=1;i<=num&&num<=20;i++)
                Console.WriteLine("N"+"*"+i+"="+i+"N");
        }
    }
}
