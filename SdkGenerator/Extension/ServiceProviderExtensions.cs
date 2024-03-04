using Microsoft.Extensions.DependencyInjection;
using SdkGenerator.Convertor.Java;
using SdkGenerator.Convertor.Typescript;

namespace SdkGenerator.Extension;

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