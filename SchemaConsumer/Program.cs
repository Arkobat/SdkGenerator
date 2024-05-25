// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using Microsoft.Extensions.DependencyInjection;
using SchemaConsumer.Convertor;
using SchemaConsumer.Convertor.Java;
using SchemaConsumer.Convertor.Typescript;
using SchemaConsumer.Model;
using SchemaConsumer.Service;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

IServiceCollection serviceCollection = new ServiceCollection();
serviceCollection
    .AddScoped<IDeserializer>(_ => new DeserializerBuilder()
        .WithNamingConvention(CamelCaseNamingConvention.Instance)
        .Build())
    .AddScoped<ConvertorOptions>()
    .AddSingleton<ConverterService>()
    .AddSingleton<DtoDirectory>()
    .AddScoped<IClassConvertor, JavaClassConvertor>()
    .AddScoped<ITypeConvertor, JavaStringConvertor>()
    .AddScoped<ITypeConvertor, JavaBoolConvertor>()
    .AddScoped<ITypeConvertor, JavaIntConvertor>()
    .AddScoped<ITypeConvertor, JavaDoubleConvertor>()
    .AddScoped<ITypeConvertor, JavaDateConvertor>()
    .AddScoped<IClassConvertor, TypeScriptClassConvertor>()
    .AddScoped<ITypeConvertor, TsNumberConvertor>()
    ;

var serviceProvider = serviceCollection.BuildServiceProvider();

var dtoDirectory = serviceProvider.GetRequiredService<DtoDirectory>();
dtoDirectory
    .Register<object>("object")
    .Register<bool>("boolean")
    .Register<char>("char")
    .Register<string>("string")
    .Register<int>("int32")
    .Register<long>("int64")
    .Register<float>("float")
    .Register<double>("double")
    .Register<Guid>("guid")
    .Register<DateOnly>("dateOnly")
    .Register<DateTime>("date")
    .Register<DateTimeOffset>("dateTimeOffset")
    .Register(typeof(List<>), "List")
    .Register(typeof(Dictionary<object, object>), "Map");

foreach (var value in dtoDirectory.DefaultSchemas.Values)
{
    dtoDirectory.Register(value);
}

var converter = serviceProvider.GetRequiredService<ConverterService>();
var stopwatch = Stopwatch.StartNew();
converter.Convert(Language.Java);
var stopwatchElapsedMilliseconds = stopwatch.ElapsedMilliseconds;
Console.WriteLine($"Elapsed time: {stopwatchElapsedMilliseconds} ms");

