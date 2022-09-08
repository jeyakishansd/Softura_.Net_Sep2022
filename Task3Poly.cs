using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task3Poly
    {
        public  void userLogin(String email,String Password)
        {
            Console.WriteLine("EmailID : {0} , Password : {1}",email,Password);
        }
        public void userLogin(String membership_ID, int pin)
        {
            Console.WriteLine("Membership_ID : {0} , Pin : {1}",membership_ID,pin);
        }
        public void userLogin(long Mobile_Number, int pin)
        {
            Console.WriteLine("Mobile number : {0} ,Pin :{1}",Mobile_Number,pin);

        }
        public static void Main()
        {
            Task3Poly Poly = new Task3Poly();
            Poly.userLogin("jeyaki.kishan@gmail.com", "jeykee");
            Poly.userLogin("JK3699", 3699         );
            Poly.userLogin(7639575709, 3699);
            
        }

    }
}
