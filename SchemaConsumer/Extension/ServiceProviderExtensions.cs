using Microsoft.Extensions.DependencyInjection;
using SchemaConsumer.Convertor.Java;
using SchemaConsumer.Convertor.Typescript;

namespace SchemaConsumer.Extension;

public static class ServiceProviderExtensions
{
    public static IServiceCollection AddJava(this IServiceCollection provider)
    {
        return provider
            .AddScoped<JavaClassConvertor>()
            .AddScoped<JavaIntConvertor>();
    }

    public static IServiceCollection AddTypeScript(this IServiceCollection provider)
    {
        return provider
            .AddScoped<TsNumberConvertor>();
    }
}