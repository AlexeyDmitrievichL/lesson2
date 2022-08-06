using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class User
    {
        private string age;

        public void GetAge()
        {
            Console.WriteLine("Set age");
            age = Console.ReadLine();
            Console.WriteLine($"Setted age: {age}");
            Console.ReadKey();
        }
    }
}
