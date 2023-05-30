using Microsoft.Extensions.DependencyInjection;

namespace Driven.Persistence;
public static class DependencyInjection
{
    public static IServiceCollection AddPersistenceDriven(this IServiceCollection services)
    {
        return services;
    }
}
