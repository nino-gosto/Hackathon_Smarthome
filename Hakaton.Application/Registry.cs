using FluentValidation;
using Microsoft.Extensions.DependencyInjection;

using Hakaton.Core;
using Hakaton.Application.Interfaces;
using RideWithMe.Application;

namespace Hakaton.Application
{
    public static class Registry
    {
        public static void AddApplication(this IServiceCollection services)
        {
            services.AddScoped<IDeviceActionsService, DeviceActionsService>();
            services.AddScoped<IDevicesService, DevicesService>();
            services.AddScoped<IDeviceTypesService, DeviceTypesService>();
            services.AddScoped<IHomesService, HomesSevice>();
            services.AddScoped<IRoomsService, RoomsService>();
            services.AddScoped<IUsersService, UsersService>();
        }

        public static void AddValidators(this IServiceCollection services)
        {
            services.AddScoped<IValidator<DeviceActionUpsertDto>, DeviceActionValidator>();
            services.AddScoped<IValidator<DeviceUpsertDto>, DeviceValidator>();
            services.AddScoped<IValidator<DeviceTypeUpsertDto>, DeviceTypeValidator>();
            services.AddScoped<IValidator<HomeUpsertDto>, HomeValidator>();
            services.AddScoped<IValidator<RoomUpsertDto>, RoomValidator>();
            services.AddScoped<IValidator<UserUpsertDto>, UserValidator>();
        }
    }
}
