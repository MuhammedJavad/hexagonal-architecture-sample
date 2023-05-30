using Domain.Ports.Driven;
using Microsoft.Extensions.DependencyInjection;

namespace Driven.Motor;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceDriven(this IServiceCollection services)
    {
        services.AddScoped<IMotorPort, MotorAdapter>();
        return services;
    }
}
