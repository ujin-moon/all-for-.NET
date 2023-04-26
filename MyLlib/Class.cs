using static System.Console; // используем для сокращения 
namespace MyLib
{
    public class Counter
    {
        public int Value { get; set; }

        public static Counter operator +(Counter counter1, Counter counter2)
        {
            return new Counter { Value = counter1.Value + counter2.Value };
        }
        public static bool operator >(Counter counter1, Counter counter2)
        {
            return counter1.Value > counter2.Value;
        }
        public static bool operator <(Counter counter1, Counter counter2)
        {
            return counter1.Value < counter2.Value;
        }
    }
    public class Person
    {
        public string Name { get; }
        public Person(string name) => Name = name;
    }
    public class Company
    {
        Person[] personal;
        public Company(Person[] people) => personal = people;
        // индексатор
        public Person this[int index]
        {
            get => personal[index];
            set => personal[index] = value;
        }
    }
}