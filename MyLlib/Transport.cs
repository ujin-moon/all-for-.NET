using static System.Console; // используем для сокращения 
namespace MyLib
{
    public abstract class Transport
    {
        public string Name { get; }
        public Transport(string name)
        { this.Name = name; }
        public abstract int Speed { get; set; }
        public abstract void Move();
    }
    // класс машины
    public abstract class Car : Transport 
    {
        public Car(string name) : base(name) { }
    }
    public class Auto : Car 
    {
        public Auto(string name) : base(name) { }
        public override int Speed { get; set; }
        public override void Move()
        {
            WriteLine($"Легковая {Name} едет, со скоростью {Speed} км/ч");
        }
    }
    // класс корабля
    public class Ship : Transport
    {
        public Ship(string name) : base(name) { }
        // мы должны реализовать все абстрактные методы и свойства базового класса
        int speed;
        public override int Speed { 
            get => speed; 
            set => speed = value; }
        public override void Move()
        {
            WriteLine($"{Name} плывет, со скоростью {Speed} км/ч ");
        }
    }
    // класс самолета
    public class Aircraft : Transport
    {
        public Aircraft(string name) : base(name) { }
        public override int Speed {get; set;}
        public override void Move()
        {
            WriteLine($"{Name} летит, со скоростью {Speed} км/ч");
        }
    }
    public class Person<T>
    {
        public T Id { get; set; }
        public string Name { get; set; }
        public Person(T id, string name)
        {
            Id = id;
            Name = name;
        }
    }
}