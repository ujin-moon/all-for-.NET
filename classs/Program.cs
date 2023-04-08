using System;
using Persons;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace classs
{
    class Program
    {
        static void Main(string[] args)
        {
            State state1 = new State(); // Структура State
            State state2 = new State();
            state2.x = 1;
            state2.y = 2;
            state1 = state2;
            state2.x = 5; // state1.x=1 по-прежнему
            Console.WriteLine(state1.x); // 1
            Console.WriteLine(state2.x); // 5

            Country country1 = new Country(); // Класс Country
            Country country2 = new Country();
            country2.x = 1;
            country2.y = 4;
            country1 = country2;
            country2.x = 7; // теперь и country1.x = 7, так как обе ссылки и country1 и country2 
                            // указывают на один объект в хипе
            Console.WriteLine(country1.x); // 7
            Console.WriteLine(country2.x); // 7
            Person person = new Person() { Name = "John", Age = 12 };
            person.PrintInfo("John", 12);
            Console.ReadLine();
        }

        struct State
        {
            public int x;
            public int y;
        }
        class Country
        {
            public int x;
            public int y;
        }
    }
}
