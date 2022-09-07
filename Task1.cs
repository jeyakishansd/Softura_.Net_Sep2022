using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task1
    {
        public static void Main()
        {
            Console.Write("Enter the Number of units :");
            int units=Convert.ToInt32(Console.ReadLine());
            if (units <= 200)
                Console.WriteLine(units * 2);
            else if (units >= 201 && units <= 350)
            {
                int value = units - 200;
                Console.WriteLine("the value is{0}", 400 + value * 3);
            }
            else if (units >= 351 && units <= 500)
            {
                int val = units - 350;
                Console.WriteLine("the value is {0}", 850 + val * 5);
            }
            else if (units >= 501)
            {
                int valuee = units - 500;
                Console.WriteLine("the value is {0}", 1600 + valuee * 7);    
            } 
        }
    }
}
