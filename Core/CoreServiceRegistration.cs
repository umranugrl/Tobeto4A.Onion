using Microsoft.Extensions.DependencyInjection;

namespace Core
{
    public static class CoreServiceRegistration
    {
        public static IServiceCollection AddCoreServices(this IServiceCollection services)
        {
            //services.AddScoped<ITokenHelper, JwtHelper>(_ => new JwtHelper(tokenOptions));
            return services;
        }
    }
}
