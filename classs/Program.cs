using System;
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
            Calculate(5);
            Console.ReadLine(); 
        }

        static void Calculate(int t)
        {
            int x = 6;
            int y = 7;
            int z = y + t;
            Console.WriteLine($"Итоговое число {z}");
        }
    }
}
