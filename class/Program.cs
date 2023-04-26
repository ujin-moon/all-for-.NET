//Вывод многострочной строки
using System.Text.RegularExpressions;

string txt = """ 
    if(i == love_you){
    married = true;
    }
    else{
    married = false;
    }
    """;
WriteLine(txt);


//Регулярные выражения
string pattern = @"^(?("")(""[^""]+?""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9]{2,17}))$";
var data = new string[]
{
    "tom@gmail.com",
    "+12345678999",
    "bob@yahoo.com",
    "+13435465566",
    "sam@yandex.ru",
    "+43743989393"
};

WriteLine("Email List");
for (int i = 0; i < data.Length; i++)
{
    if (Regex.IsMatch(data[i], pattern, RegexOptions.IgnoreCase))
    {
        WriteLine(data[i]);
    }
}

string phoneNumber = "+1(876)-234-12-98";
string pattern1 = @"\D";
string target = "";
Regex regex = new Regex(pattern1);
string result = regex.Replace(phoneNumber, target);
WriteLine(result);  // 18762341298