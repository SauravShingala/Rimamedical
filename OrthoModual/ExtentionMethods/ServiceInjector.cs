using OrthoModual.IServices;
using OrthoModual.Services;

namespace OrthoModual.ExtentionMethods
{
    public static class ServiceInjector
    {
        public static IServiceCollection UseServiceInjector(this IServiceCollection services)
        {
            services.AddScoped<IAddSubmenuService,AddSubmenuService>();
            services.AddScoped<IOrthoFormService, OrthoFormService>();

            return services;
        }
    }
}
