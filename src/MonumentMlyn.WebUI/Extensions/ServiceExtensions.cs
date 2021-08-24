using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MonumentMlyn.BLL.Services;
using MonumentMlyn.BLL.Services.Impl;
using MonumentMlyn.DAL.Repositorie;
using MonumentMlyn.DAL.Repositorie.Impl;

namespace MonumentMlyn.WebUI.Extensions
{
    public static class ServiceExtensions
    {
        public static void ConfigureCors(this IServiceCollection services) =>
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IUnitOfWork, UnitOfWorkImpl>();

        public static void ConfigureAppointmentService(this IServiceCollection service) =>
            service.AddScoped<IAppointmentServices, AppointmentServiceImpl>();
    }
}
