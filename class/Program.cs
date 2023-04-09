






Person tom = new Person("Tom");
Console.WriteLine(tom.name);

//tom.name = "Sam"; // !Ошибка: нельзя изменить







string? name = null;

PrintUpper(name);

void PrintUpper(string text)
{
    if (text == null) Console.WriteLine("null");
    else Console.WriteLine(text.ToUpper());
}





Console.ReadLine();

