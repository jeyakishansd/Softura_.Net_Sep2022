using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonsoleApp
{
    internal class Task5NameAge
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Display(string Name, int Age)
        {
            Console.WriteLine("{0} is {1} years old", Name, Age);
        }
        public static void Main()
        {
            Task5NameAge obj = new Task5NameAge()
            {
                Age = 3,
                Name = "Dhanvik"
            };
            Console.WriteLine("{0} is {1} years old", obj.Name, obj.Age);
            obj.Display("Dhanvik", 3);
        }
    }
}
