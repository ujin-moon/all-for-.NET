using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyLib
{
    public class Dogs
    {
        public string dog_name { get; init; } = "Sam";
        public int age_dog { get; set; } = 12;
        public Dogs(string name, int age) 
        {
            dog_name = name;    
            age_dog = age;
        }
    }
}
