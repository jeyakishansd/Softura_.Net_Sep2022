using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Taskk1
    {
        public static void Main()
        {
            Console.WriteLine("Do you have travel history");
            {
                if (Console.ReadLine() == "Yes")
                    Console.WriteLine("Do your have temperature");
                else
                    Console.WriteLine("Safe not covid-19");

                {
                    if (Console.ReadLine() == "Yes")
                        Console.WriteLine(" Do you have cough/sneeze");
                    else
                        Console.WriteLine("Home Quarentine for 28days");

                    {
                        if (Console.ReadLine() == "Yes")
                            Console.WriteLine("Swab Test");
                        else
                            Console.WriteLine("Quarentine,Fever medicine");

                    }
                }
            }
                    }
                }
            }
        
    

