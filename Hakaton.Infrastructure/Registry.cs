using Microsoft.Extensions.DependencyInjection;

using Hakaton.Infrastructure.Interfaces;

namespace Hakaton.Infrastructure
{
    public static class Registry
    {
        public static void AddInfrastructure(this IServiceCollection services)
        {
            services.AddScoped<IDeviceActionsRepository, DeviceActionsRepository>();
            services.AddScoped<IDevicesRepository, DevicesRepository>();
            services.AddScoped<IDeviceTypesRepository, DeviceTypesRepository>();
            services.AddScoped<IHomesRepository, HomesRepository>();
            services.AddScoped<IRoomsRepository, RoomsRepository>();
            services.AddScoped<IUsersRepository, UsersRepository>();

            services.AddScoped<IUnitOfWork, UnitOfWork>();
        }
    }
}
