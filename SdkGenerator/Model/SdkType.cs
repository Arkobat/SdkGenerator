namespace SdkGenerator.Model;

[AttributeUsage(AttributeTargets.Property)]
public class SdkType<T> : Attribute
{
    private readonly Type _type = typeof(T);
}