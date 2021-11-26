using System.Net;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using MonumentMlyn.BLL.Services;
using MonumentMlyn.BLL.Services.Impl;
using MonumentMlyn.DAL.Entities;
using MonumentMlyn.DAL.Repositorie;
using MonumentMlyn.DAL.Repositorie.Impl;

namespace MonumentMlyn.WebUI.Extensions
{
    public static class ServiceExtensions
    {



        #region Error Hendler
        public static void ConfigureExceptionHandler(this IApplicationBuilder app, ILoggerManager logger)
        {
            app.UseExceptionHandler(appError =>
            {
                appError.Run(async context =>
                {
                    context.Response.StatusCode = (int)HttpStatusCode.InternalServerError;
                    context.Response.ContentType = "application/json";
                    var contextFeature = context.Features.Get<IExceptionHandlerFeature>();
                    if (contextFeature != null)
                    {
                        logger.LogError($"Something went wrong: {contextFeature.Error}");
                        await context.Response.WriteAsync(new ErrorDetails()
                        {
                            StatusCode = context.Response.StatusCode,
                            Message = "Internal Server Error."
                        }.ToString());
                    }
                });
            });
        }


        #endregion

        public static void ConfigureCors(this IServiceCollection services)
        {
            services.AddCors(options =>
            {
                options.AddPolicy("CorsPolicy", builder =>
                    builder.AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());
            });
            services.AddMvc();
        }

        public static void ConfigureRepositoryManager(this IServiceCollection services) =>
            services.AddScoped<IUnitOfWork, UnitOfWorkImpl>();
        public static void ConfigureLoggerService(this IServiceCollection services)
        {
            services.AddSingleton<ILoggerManager, LoggerManagerImpl>();
        }
        public static void ConfigureArticleService(this IServiceCollection service) =>
            service.AddScoped<IArticleServices, ArticleServicesImpl>();
        public static void ConfigureCustomerService(this IServiceCollection service) =>
            service.AddScoped<ICustomerServices, CustomerServicesImpl>();
        public static void ConfigureMaterialService(this IServiceCollection service) =>
            service.AddScoped<IMaterialServices, MaterialServicesImpl>();
        public static void ConfigureMonumentService(this IServiceCollection service) =>
            service.AddScoped<IMonumentServices, MonumentServicesImpl>();
        public static void ConfigurePhotoService(this IServiceCollection service) =>
            service.AddScoped<IPhotoServices, PhotoServicesImpl>();

        public static void ConfigureWorkerService(this IServiceCollection service) =>
            service.AddScoped<IWorkerServices, WorkerServicesImpl>();

        public static void ConfigureCalculationsService(this IServiceCollection service) =>
            service.AddScoped<ISalaryServices, SalaryServicesImpl>();


    }
}
