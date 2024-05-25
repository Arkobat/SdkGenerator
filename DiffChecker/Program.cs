// See https://aka.ms/new-console-template for more information

IServiceCollection serviceCollection = new ServiceCollection();
serviceCollection
    .AddScoped<ISerializer>(_ => new SerializerBuilder()
        .WithDefaultScalarStyle(ScalarStyle.DoubleQuoted)
        .WithNamingConvention(CamelCaseNamingConvention.Instance)
        .ConfigureDefaultValuesHandling(DefaultValuesHandling.OmitNull)
        .Build())
    .AddScoped<ClassProvider>()
    .AddScoped<SchemaProvider>()
    .AddSingleton<TypeMapper>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var dtoDirectory = serviceProvider.GetRequiredService<TypeMapper>();
dtoDirectory
    .AddMapping<object>("object")
    .AddMapping<bool>("boolean")
    .AddMapping<char>("char")
    .AddMapping<string>("string")
    .AddMapping<byte>("int32")
    .AddMapping<sbyte>("int32")
    .AddMapping<short>("int32")
    .AddMapping<ushort>("int32")
    .AddMapping<decimal>("int32")
    .AddMapping<int>("int32")
    .AddMapping<uint>("int32")
    .AddMapping<nint>("int32")
    .AddMapping<nuint>("int32")
    .AddMapping<long>("int64")
    .AddMapping<ulong>("int64")
    .AddMapping<float>("float")
    .AddMapping<double>("double")
    .AddMapping<Guid>("guid")
    .AddMapping<DateOnly>("dateOnly")
    .AddMapping<DateTime>("date")
    .AddMapping<DateTimeOffset>("dateTimeOffset")
    .AddMapping(typeof(List<>), "List")
    .AddMapping(typeof(HashSet<>), "List")
    .AddMapping(typeof(Dictionary<object, object>), "Map");
    
    

var schemaProvider = serviceProvider.GetRequiredService<ClassProvider>();
//schemaProvider.AddClass(typeof(AbsurdCase<object, object, object, object, object, object>));
schemaProvider.AddClass(typeof(Person<>));


var yamlSerializer= serviceProvider.GetRequiredService<ISerializer>();
Console.WriteLine(yamlSerializer.Serialize(schemaProvider.GetSchemes()));