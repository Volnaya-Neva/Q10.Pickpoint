using Q10.Pickpoint.Business.Services;
using Q10.Pickpoint.Models.Settings;

namespace Q10.Pickpoint.API.Controllers.Extensions;

public static class ServiceCollectionExtensions
{
    public static void AddAppConfiguration(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddOptions<AppConfig>()
        .Bind(configuration.GetSection(nameof(AppConfig)))
        .ValidateDataAnnotations();
    }

    public static IServiceCollection AddCustomServices(this IServiceCollection services)
    {
        services.AddScoped<ITestService, TestService>();
        return services;
    }

    public static IServiceCollection AddConnectors(this IServiceCollection services)
    {
        //services.AddTransient<In, n>();
        return services;
    }
}