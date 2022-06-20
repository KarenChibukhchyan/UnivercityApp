using Microsoft.Extensions.DependencyInjection;
using Univercity.Services.Implementation;
using Univercity.Services.Interfaces;

namespace Univercity.Services
{
    public static class DependancyInjections
    {
        public static IServiceCollection AddServices(this IServiceCollection services)
        {
            services.AddScoped<IStudentService, StudentService>();
            return services;
        }
    }
}
