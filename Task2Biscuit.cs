using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class Task2Biscuit
    {
       

        public static void Main()
        {
            String[][] categories = new string[3][];
            categories[0] = new string[4] { "Hide and seek", "Tiger", "Parle-G", "Sunfeast" };
            categories[1] = new string[5] { "gems", "kitkat", "5star", "diarymilk", "milkybar" };
            categories[2] = new string[6] { "Coke", "7up", "Soda", "Sprite", "fanta", "miranda" };
            for (int i = 0; i < categories.Length; i++)
            {
                for (int j=0;j<categories[i].Length; j++) 
                {
                    Console.Write(categories[i][j]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
