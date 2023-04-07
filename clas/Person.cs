using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clas
{
    internal class Person
    {
        public string Name;
        public int Age;

        public void PrintInfo(string Name, int Age)
        {
            Console.WriteLine($"Имя человека {Name}, возраст {Age}");
        }
    }
}
