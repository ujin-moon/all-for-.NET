namespace MyLib
{
    public class Person
    {
        static int counter = 0;
        public static int Counter => counter;
        public Person()
        {
            counter++;
        }
    }
}