using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
     abstract class ArithmeticOP
    {
        public abstract void add();
        public abstract void subtract();
        public abstract void multiply();
        public abstract void divide();
    }
    class Calculator:ArithmeticOP
    { int a, b;
        public override void add()
        {
            a = 2;
            b = 3;
            Console.WriteLine(a+ b);
        }
        public override void subtract()
        {
            a = 2;
            b = 1;
            Console.WriteLine(a- b);
        }
        public override void multiply()
        {
            a = 3;
            b = 2;
            Console.WriteLine(a*b);
        }
        public override void divide()
        {
            a = 6;
            b = 3;
            Console.WriteLine(a / b);
        }

    }
    internal class Task4Abstract
    {
        public static void Main()
        {
            Calculator cal = new Calculator();
            cal.add();
            cal.subtract();
            cal.multiply();
            cal.divide();

        }
    }
}
