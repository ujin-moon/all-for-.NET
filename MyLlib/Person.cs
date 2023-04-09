namespace MyLib
{
    public class Person
    {
        int age;
        public static int retirementAge = 65;
        public Person(int age)
        {
            this.age = age;
        }
        public void СheckAge()
        {
            if (age >= retirementAge)
                Console.WriteLine("Уже на пенсии");
            else
                Console.WriteLine($"Сколько лет осталось до пенсии: {retirementAge - age}");
        }
    }
}