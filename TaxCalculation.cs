using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class VatTax 
    {

        public void calculateTax(double BasicAmount)
        {


            double VatAmount = (BasicAmount * 0.20);
            Console.WriteLine("VAT Amount is: " + VatAmount);

        }
    }
    class GstTax : VatTax  
    {
        public new void calculateTax(double BasicAmount)
        {

            double GstAmount = (BasicAmount * 0.12);
            Console.WriteLine("GST Amount is:" + GstAmount);
        }
    }
    internal class TaxCalculation
    {
        public static void Main()
        {
            Console.WriteLine("Enter the Amount");
            double Amount = Convert.ToDouble(Console.ReadLine());
            GstTax gobj = new GstTax();
            gobj.calculateTax(Amount);
            VatTax vobj = new GstTax();
            vobj.calculateTax(Amount);
        }
    }
}
