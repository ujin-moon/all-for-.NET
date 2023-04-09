namespace MyLib
{
    public class Human
    {
        string firstname = "Undefined";
        string secondname = "Undefined";
        int age = 1;
        string name = "Undefined";
        public string Name
        {
            get { 
                return this.name;
            }
            set {
                this.Name = firstname + " " + secondname;
            }
        }
        public int Age
        {
            get { return age; } 
            set { 
                if (value < 1 || value > 120) 
                    Console.WriteLine("Значение должно быть не меньше 1 и не больше 120");
                else
                    age = value;
            } 
        }
        public Human(string firstname, string secondname, int age)
        {
            this.firstname = firstname;
            this.secondname = secondname;
            this.name = firstname + " " + secondname;   
            Age = age;
        }

        public void PrintInfo(string name, int age)
        {
            Console.WriteLine($"Имя человека {name}, возраст {age}");
        }
    }
}