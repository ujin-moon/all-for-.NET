namespace MyLib
{
    public class Person
    {
        static int retirementAge;
        public static int RetirementAge => retirementAge;
        static Person()//Создание статического конструктора
        {
            if (DateTime.Now.Year == 2023)//Применение DateTime.Now.Year для проверки текущего года
                retirementAge = 65;
            else
                retirementAge = 67;
        }
    }
}