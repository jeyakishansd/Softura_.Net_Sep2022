using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Add_Sub
    {
        public void add(int i,int j)
        {
            Console.WriteLine(i + j);
        }
        public void sub(int i,int j)
        {
            Console.WriteLine(i - j);
        }
    }
    class Multiply_Divide : Add_Sub
    {
        public void multiply(int i,int j)
        {
            Console.WriteLine(i* j);
        }
        public void divide(int i,int j)
        {
            Console.WriteLine(i/j);
        }
    }
    internal class Task3ArithmeticOperations
    {
        public static void Main()
        {
            Multiply_Divide mobj = new Multiply_Divide();
            mobj.add(2,1);
            mobj.sub(8,2);
            mobj.multiply(3,3);
            mobj.divide(18, 2);
        }
    }
}

