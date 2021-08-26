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
        public static void ConfigureArticleService(this IServiceCollection service) =>
            service.AddScoped<IArticleServices, ArticleServicesImpl>();
        public static void ConfigureCategoryMaterialService(this IServiceCollection service) =>
            service.AddScoped<ICategoryMaterialServices, CategoryMaterialServicesImpl>();
        public static void ConfigureCategoryPhotoService(this IServiceCollection service) =>
            service.AddScoped<ICategoryPhotoServices, CategoryPhotoServicesImpl>();
        public static void ConfigureCustomerService(this IServiceCollection service) =>
            service.AddScoped<ICustomerServices, CustomerServicesImpl>();
        public static void ConfigureMaterialService(this IServiceCollection service) =>
            service.AddScoped<IMaterialServices, MaterialServicesImpl>();
        public static void ConfigureMonumentService(this IServiceCollection service) =>
            service.AddScoped<IMaterialServices, MaterialServicesImpl>();
        public static void ConfigurePhotoService(this IServiceCollection service) =>
            service.AddScoped<IPhotoServices, PhotoServicesImpl>();
        public static void ConfigureRoleService(this IServiceCollection service) =>
            service.AddScoped<IRoleServices, RoleServicesImpl>();
        public static void ConfigureUserService(this IServiceCollection service) =>
            service.AddScoped<IUserServices, UserServicesImpl>();
        public static void ConfigureWorkerService(this IServiceCollection service) =>
            service.AddScoped<IWorkerServices, WorkerServicesImpl>();


    }
}
