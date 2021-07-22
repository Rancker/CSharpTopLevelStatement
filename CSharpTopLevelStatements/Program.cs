System.Console.WriteLine("Args: " + args?[0]);
var person = new Person { FirstName = "Chhavi", LastName = "Goel" };
System.Console.WriteLine($"Name: {person.FirstName} {person.LastName}");

public class Person
{
    public string FirstName { get; set; }
    public string LastName { get; set; }
}