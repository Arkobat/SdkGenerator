// See https://aka.ms/new-console-template for more information

using Microsoft.Extensions.DependencyInjection;
using SdkGenerator.Convertor;
using SdkGenerator.Convertor.Java;
using SdkGenerator.Convertor.Typescript;
using SdkGenerator.Model;
using SdkGenerator.Service;
using SdkGenerator.Service.Updated;

new UpdatedProgram().Start();

/*

IServiceCollection serviceCollection = new ServiceCollection();
serviceCollection
    .AddScoped<DtoDirectory>()
    .AddScoped<IClassConvertor, JavaClassConvertor>()
    .AddScoped<IClassConvertor, TypeScriptClassConvertor>()
    .AddScoped<ConverterService>()
    .AddScoped<ConvertorOptions>()
    .AddScoped<ExtractorService>();

var serviceProvider = serviceCollection.BuildServiceProvider();

var extractorService = serviceProvider.GetRequiredService<ExtractorService>();
extractorService.AutoRegister();

var converter = serviceProvider.GetRequiredService<ConverterService>();
converter.Convert(Language.Java);
//var template = Template.ParseLiquid(file);
//
//foreach (var type in dtoDirectory.GetAll())
//{
//    var result = template.Render(type);
//    Console.WriteLine(result);
//}
*/