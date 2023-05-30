using Domain.Ports.Driving;
using Microsoft.Extensions.DependencyInjection;

namespace Driving.Sensors;
public static class DependencyInjection
{
    public static IServiceCollection AddSensorsDriving(this IServiceCollection services)
    {
        services.AddScoped<ILightingSensorPort, LightingSensorAdapter>();
        services.AddScoped<ITemperatureSensorPort, TemperatureSensorAdapter>();
        return services;
    }
}
