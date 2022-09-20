using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsoleApp
{
    internal class Task6Dessertscs
    {public static void Main()
        {
            List<string> li = new List<string>();
            li.Add("Vanilla");
            li.Add("Strawberry");
            li.Add("Butterscotch");
            li.Add("Cotton Candy");
            li.Add("Boomer");
            li.Add("Watermelon");
            li.Add("Pineapple");
            li.Add("Blueberry");
            li.Add("Blue Current");
            li.Add("Blue Forest");
            li.Add("kulfi");

            FileStream fs = new FileStream("D:\\Softura Training\\KonsoleApp\\KonsoleApp\\Dessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamWriter sw=new StreamWriter(fs);
            sw.BaseStream.Seek(0, SeekOrigin.End);
            foreach (string i in li)
                sw.WriteLine(i);
            sw.Flush();
            sw.Close();

            FileStream fs1 = new FileStream("D:\\Softura Training\\KonsoleApp\\KonsoleApp\\Dessert.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            StreamReader sr = new StreamReader(fs1);
            sr.BaseStream.Seek(0, SeekOrigin.Begin);
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
            fs1.Close();

            FileInfo fi = new FileInfo("D:\\Softura Training\\KonsoleApp\\KonsoleApp\\Dessert.txt");
            Console.WriteLine("File Created time:" + fi.CreationTime);
            Console.WriteLine("Length of the file: " + fi.Length);
        }
    }
}
