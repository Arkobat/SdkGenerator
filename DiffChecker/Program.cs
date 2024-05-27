// See https://aka.ms/new-console-template for more information

using System.Diagnostics;
using DiffChecker.Service;
using Microsoft.Extensions.DependencyInjection;
using SchemaConsumer.Shared.Model;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

var serviceProvider = new ServiceCollection()
    .AddScoped<IDeserializer>(_ => new DeserializerBuilder()
        .WithNamingConvention(CamelCaseNamingConvention.Instance)
        .Build())
    .AddScoped<DiffService>()
    .BuildServiceProvider();


var deserializer = serviceProvider.GetRequiredService<IDeserializer>();
var oldSchemas = YamlProvider.AllSchemes(deserializer).Values.ToList();
var newSchemes = YamlProvider.AllSchemes(deserializer).Values.ToList();

//((ObjectSchema) oldSchemas[0]).Name = "ChangedName_1";
//((ObjectSchema) newSchemes[10]).Name = "ChangedName_2";
//((ObjectSchema) oldSchemas[30]).Name = "ChangedName_3";
//((ObjectSchema) newSchemes[50]).Name = "ChangedName_4";
//((ObjectSchema) oldSchemas[70]).Name = "ChangedName_5";
//((ObjectSchema) newSchemes[00]).Name = "ChangedName_6";

((ObjectSchema) newSchemes[0]).Properties[0].Type = "ChangedType";


var diffService= serviceProvider.GetRequiredService<DiffService>();

var stopwatch = Stopwatch.StartNew();
var result = diffService.Compare(oldSchemas, newSchemes);
var stopwatchElapsedMilliseconds = stopwatch.ElapsedMilliseconds;
Console.WriteLine($"Elapsed time: {stopwatchElapsedMilliseconds} ms");
