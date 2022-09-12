using ConsoleApp;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Silver : MembershipPackage
    {
        public void accomodation()
        {
            Console.WriteLine("Silver: 3 days accomodation at Resort");
        }
    }
    class gold : MembershipPackage
    {
        public void accomodation()
        {
            Console.WriteLine("Gold :5 days accomodation at Resort & 2 dinners at the House");
        }
    }
    class Platinum : MembershipPackage
    {
        public void accomodation()
        {
            Console.WriteLine("Platinum :7 days accomodation at Resort & 5 dinners on the House");
        }  
    }
    internal class Task4Membership
    {
        public static void Main()
        {
            Silver sil = new Silver();
            gold gol = new gold();
            Platinum pl = new Platinum();
            sil.accomodation();
            gol.accomodation();
            pl.accomodation();
        }
    }
}
