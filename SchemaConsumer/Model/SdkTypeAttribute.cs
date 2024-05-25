namespace SchemaConsumer.Model;

[AttributeUsage(AttributeTargets.Property)]
public class SdkTypeAttribute<T> : Attribute
{
    private readonly Type _type = typeof(T);
}