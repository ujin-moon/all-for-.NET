using static System.Console; // используем для сокращения 
namespace MyLib
{
    public class Messenger<T, P>
        where T : Message
        where P : Person
    {
        public void SendMessage(P sender, P receiver, T message)
        {
            WriteLine($"Отправитель: {sender.Name}");
            WriteLine($"Получатель: {receiver.Name}");
            WriteLine($"Текст сообщения: {message.Text}");
        }
    }
    public class Person
    {
        public string Name { get; }
        public Person(string name)
        {
            Name = name;
        }
        
    }
    public class Message
    {
        public string Text { get; } // текст сообщения
        public Message(string text)
        {
            Text = text;
        }
    }
}