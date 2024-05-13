// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using SdkGenerator.Convertor;
using SdkGenerator.Convertor.Java;
using SdkGenerator.Convertor.Typescript;
using SdkGenerator.Model;
using SdkGenerator.Service;
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
    .Register<int>("int32")
    .Register<long>("int64")
    .Register<Guid>("guid")
    .Register<DateOnly>("dateOnly")
    .Register<DateTime>("date")
    .Register<DateTimeOffset>("dateTimeOffset");

foreach (var value in dtoDirectory.DefaultSchemas.Values)
{
    dtoDirectory.Register(value);
}

var converter = serviceProvider.GetRequiredService<ConverterService>();
converter.Convert(Language.Java);

