Counter counter3 = new Counter { Value = 23 };
Counter counter4 = new Counter { Value = 45 };

bool result = counter3 > counter4;
Counter c3 = counter3 + counter4;
WriteLine(c3.Value);
WriteLine(result);



var microsoft = new Company(new[]
{
    new Person("Tom"), new Person("Bob"), new Person("Sam"), new Person("Alice")
});
// получаем объект из индексатора
Person firstPerson = microsoft[0];
WriteLine(firstPerson.Name);  // Tom
// переустанавливаем объект
microsoft[0] = new Person("Mike");
WriteLine(microsoft[0].Name);  // Mike

WriteLine(firstPerson.Name);  // Tom

Print();
PrintValue("hello");

string txt = """
    if(i == love_you){
    married == true;
    }
    else {
    married == false;
    }
    """;

WriteLine(txt); 

void Print()
{
    string text = """
              Привет
              Мир
              Как 
              Дела?
              """;
    WriteLine(text);
}

void PrintValue(string val)
{
    string text = $"""
              <element attr="content">
                <body>
                {val}
                </body>
              </element>
              """;
    //// или так 
    //string text =  $$"""
    //          <element attr="content">
    //            
    //            {{val}}
    //            
    //          </element>
    //          """;
    WriteLine(text);
}