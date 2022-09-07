using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task2TV
    {
        public static void Main()
        {
            String[] package_A = { "South Specials", "Children's club", "Movies" };
            for     (int i=0; i < package_A.Length; i++)
            {
                Console.WriteLine(package_A[i]);
            }
            String[] package_B = { "News", "Sports", "Movies", "Regional2" };
            for (int i = 0; i < package_B.Length; i++)
            {
                Console.WriteLine(package_B[i]);
            }
                String[] package_C = { "Discovery", "History", "National" };
            for (int i=0; i < package_C.Length; i++)
            {
                Console.WriteLine(package_C[i]);
            }
            
          Console.WriteLine("Select a package");
            String package=Console.ReadLine();
             switch(package)
            {
                case "package_A":Console.WriteLine("The amount is 250");
                    break;
                case "package_B":Console.WriteLine("The amount is 450");
                    break;
                case "package_C":Console.WriteLine("The amount is 350");
                    break ;
                default:Console.WriteLine("Select Package_A or Package_B or Package_C" );
                    break;
            }

          
            
                    



        }
    }
}
