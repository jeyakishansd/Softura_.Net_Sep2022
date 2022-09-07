using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Tassk2Marks
    {
        public static void Main()
        {
            int[] array = { 78, 97, 67, 87, 86 };
            int total = array[0] + array[1] + array[2] + array[3] + array[4] ;
            Console.WriteLine(total);
            Console.WriteLine("The percentage is {0}",total/5);   
        }
            }
}
