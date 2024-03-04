// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using Scriban;
using SdkGenerator.Service;


IServiceCollection serviceCollection = new ServiceCollection();
serviceCollection
    .AddScoped<DtoDirectory>()
    .AddScoped<ExtractorService>();

var serviceProvider = serviceCollection.BuildServiceProvider();
var extractorService = serviceProvider.GetRequiredService<ExtractorService>();

extractorService.AutoRegister();
//var template = Template.ParseLiquid(file);
//
//foreach (var type in dtoDirectory.GetAll())
//{
//    var result = template.Render(type);
//    Console.WriteLine(result);
//}