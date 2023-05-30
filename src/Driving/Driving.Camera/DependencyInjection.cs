using Domain.Ports.Driving;
using Microsoft.Extensions.DependencyInjection;

namespace Driving.Camera;

public static class DependencyInjection
{
    public static IServiceCollection AddCameraDriving(this IServiceCollection services)
    {
        services.AddScoped<ICameraPort, CameraAdapter>();
        return services;
    }
}
