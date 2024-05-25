// See https://aka.ms/new-console-template for more information

using DiffChecker.Service;
using Microsoft.Extensions.DependencyInjection;

IServiceCollection serviceCollection = new ServiceCollection();
serviceCollection
    .AddScoped<DiffService>()
    .AddScoped<SchemaProvider>()
    .AddSingleton<TypeMapper>();



var schemaProvider = serviceProvider.GetRequiredService<ClassProvider>();
//schemaProvider.AddClass(typeof(AbsurdCase<object, object, object, object, object, object>));
schemaProvider.AddClass(typeof(Person<>));


var yamlSerializer= serviceProvider.GetRequiredService<ISerializer>();
Console.WriteLine(yamlSerializer.Serialize(schemaProvider.GetSchemes()));