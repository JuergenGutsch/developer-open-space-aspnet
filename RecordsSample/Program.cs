
Person person1 = new(1, "Foo", "Bar");
Person person2 = new(1, "Foo", "Bar");

// See https://aka.ms/new-console-template for more information
Console.WriteLine(person1);
Console.WriteLine(person1 == person2);



public record Person(int Id, string Firstname, string Lastname);



//public record struct PersonC(int Id, string Firstname, string Lastname);