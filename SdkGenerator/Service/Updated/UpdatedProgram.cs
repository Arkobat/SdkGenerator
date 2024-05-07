using Microsoft.Extensions.DependencyInjection;
using SdkGenerator.Convertor;
using SdkGenerator.Convertor.Java;
using SdkGenerator.Convertor.Typescript;
using SdkGenerator.Model;
using SdkGenerator.Model.Definition;

namespace SdkGenerator.Service.Updated;

public class UpdatedProgram
{
    public void Start()
    {
        IServiceCollection serviceCollection = new ServiceCollection();
        serviceCollection
            .AddScoped<ConvertorOptions>()
            .AddSingleton<ConverterService>()
            .AddSingleton<DtoDirectory>()
            .AddScoped<IClassConvertor, JavaClassConvertor>()
            .AddScoped<ITypeConvertor, JavaStringConvertor>()
            .AddScoped<ITypeConvertor, JavaIntConvertor>()
            
            .AddScoped<IClassConvertor, TypeScriptClassConvertor>()
            .AddScoped<ITypeConvertor, TsNumberConvertor>()
            ;

        var serviceProvider = serviceCollection.BuildServiceProvider();

        var dtoDirectory = serviceProvider.GetRequiredService<DtoDirectory>();
        dtoDirectory
            .Register<bool>("boolean")
            .Register<char>("char")
            .Register<string>("string")
            //.Register<byte>("int32")
            //.Register<sbyte>("int32")
            //.Register<short>("int32")
            //.Register<ushort>("int32")
            //.Register<decimal>("int32")
            .Register<int>("int32")
            //.Register<uint>("int32")
            //.Register<nint>("int32")
            //.Register<nuint>("int32")
            .Register<long>("int64")
            //.Register<ulong>("int64")
            //.Register<float>("float")
            //.Register<double>("double")
            .Register<Guid>("guid")
            .Register<DateOnly>("dateOnly")
            .Register<DateTime>("date")
            .Register<DateTimeOffset>("dateTimeOffset");
        
        GetSchemas.ForEach(dtoDirectory.Register);

        var converter = serviceProvider.GetRequiredService<ConverterService>();
        converter.Convert(Language.Java);
    }

    public List<Schema> GetSchemas => new()
    {
        new ObjectSchema
        {
            Namespace = "SdkGenerator.PersonExample",
            Name = "Person",
            Properties =
            [
                new SchemaProperty
                {
                    Type = "string",
                    Name = "FirstName"
                },
                new SchemaProperty
                {
                    Type = "string",
                    Name = "LastName"
                },
                new SchemaProperty
                {
                    Type = "int32",
                    Name = "Age"
                },
                new SchemaProperty
                {
                    Type = "SdkGenerator.PersonExample.Address",
                    Name = "Address",
                    Nullable = true
                },
                new SchemaProperty
                {
                    Type = "SdkGenerator.PersonExample.Company",
                    Name = "Company",
                    Nullable = true
                }
            ]
        },
        new ObjectSchema
        {
            Namespace = "SdkGenerator.PersonExample",
            Name = "Company",
            Properties =
            [
                new SchemaProperty
                {
                    Type = "string",
                    Name = "StreetName"
                },
                new SchemaProperty
                {
                    Type = "string",
                    Name = "Number"
                }
            ]
        },
    };
}
