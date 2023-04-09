namespace MyLib
{
    public class Person
    {
        public int Age { get; set; }
        static int retirementAge = 65;
        public Person(int age) => Age = age;
        public static void CheckRetirementStatus(Person person)//В статическом методе только статические переменные
        {
            if (person.Age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - person.Age}");
        }
    }
}