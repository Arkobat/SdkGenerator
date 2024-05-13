namespace SchemaExtractor.Model.Example;

public class Person<T>
{
    public required Guid PersonId { get; set; }
    public required string FirstName { get; set; } 
    public required string? MiddleName { get; set; } 
    public required string LastName { get; set; } 
    public required int Age { get; set; } 
    public required DateOnly Birthday { get; set; } 
    public required Gender Gender { get; set; } 
    public required List<Person<T>> Parents { get; set; }
    public required Dictionary<string, Address> Address { get; set; }
    public required HashSet<string> RandomSet { get; set; }
}

public class Address
{
    public required string Street { get; set; } 
    public required int Number { get; set; } 
}

public enum Gender
{
    Male,
    Female,
}