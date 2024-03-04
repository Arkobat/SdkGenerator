namespace SdkGenerator.Model.Example;

public class Person
{
    public required string FirstName { get; set; }
    public required string LastName { get; set; }
    public required int Age { get; set; }
    public required Address Address { get; set; }
    public required List<Job> Jobs { get; set; }
}