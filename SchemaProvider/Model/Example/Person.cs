namespace SchemaExtractor.Model.Example;

public abstract class LivingEntity
{
    public required int Age { get; set; } 
    public required DateOnly Birthday { get; set; } 
}
public class Person<T>
{
    public required string Name { get; set; } 
    public required Gender Gender { get; set; } 
    public required T GenericProp { get; set; }
    public required List<Person<T>> Parents { get; set; }
    public required Dictionary<string, Address> Address { get; set; }
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