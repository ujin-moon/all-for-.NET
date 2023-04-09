
using static System.Console; // используем для сокращения 




PrintNullable(5);       // 5
PrintNullable(null);    // параметр равен null

PrintUpper("dsda");
PrintUpper(null);

string? text = null;
string name = text ?? "Tom";  // равно Tom, так как text равен null
WriteLine(name);    // Tom

int? id = 200;
int personid = id ?? 1; // равно 200, так как id не равен null
WriteLine(personid);    // 200

Company company = new Company();
company.WebSite = "Andersen.com";
Person person = new Person();
person.Company = company;

PrintWebSite(person);

void PrintNullable(int? number)
{
    if (number.HasValue)//Проверка на то что имеет значение
    {
        WriteLine(number.Value);
        // аналогично
        //WriteLine(number);
    }
    else
    {
        WriteLine("параметр равен null");
    }
}
void PrintUpper(string? text)
{
    if (text is null) return;//is - используется как проверка и если верно, то = true, else = false (обратным будет is not)
    WriteLine(text.ToUpper());
}
void PrintWebSite(Person? person)
{
    WriteLine(person?.Company?.WebSite?.ToUpper());//объект?. - проверка на пустоту(компания не пустая, вебсайт не пустой)
}
class Person
{
    public Company? Company { get; set; }   // место работы
}
class Company
{
    public string? WebSite { get; set; }    // веб-сайт компании
}




