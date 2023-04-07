using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classs
{
    internal class Program
    {
        public struct Dog {
            public string name;
            public int age;

            public void Print()
            {
                Console.WriteLine($"Имя собаки: {name}, возвраст {age} лет");
            }
        
        }

        static void Main(string[] args)
        {        
            Dog dog1 = new Dog();
            dog1.name = "Tom";
            dog1.age = 5;
            dog1.Print();


            Person person1 = new Person();
            person1.PrintInfo("Андрей", 12);
            Console.ReadLine();
        }


    }
}
