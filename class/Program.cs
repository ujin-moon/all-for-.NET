Messenger<Message, Person> google = new Messenger<Message, Person>();

Person tom = new("Tom");
Person bob = new("Bob");

Message hello = new("Hello world");
google.SendMessage(tom, bob, hello);