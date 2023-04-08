using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persons
{
    internal class Person
    {
        public string Name = "Undefined";
        public int Age = 1;

        public void PrintInfo(string Name, int Age)
        {
            Console.WriteLine($"Имя человека {Name}, возраст {Age}");
        }
    }
}
