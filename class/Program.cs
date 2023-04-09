

Person bob = new(66);
bob.СheckAge();     // Уже на пенсии

Person tom = new(49);
tom.СheckAge();     // Сколько лет осталось до пенсии: 28

// получение статического поля
Console.WriteLine(Person.retirementAge); // 65
// изменение статического поля
Person.retirementAge = 67;
bob.СheckAge();

Console.ReadLine();

