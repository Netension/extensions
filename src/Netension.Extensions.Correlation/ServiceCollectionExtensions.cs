using Microsoft.Extensions.DependencyInjection;

namespace Netension.Extensions.Correlation
{
    public static class ServiceCollectionExtensions
    {
        public static void RegistrateCorrelation(this IServiceCollection services)
        {
            services.AddScoped<CorrelationContext>();
            services.AddScoped<ICorrelationAccessor>((provider) => provider.GetRequiredService<CorrelationContext>());
            services.AddScoped<ICorrelationMutator>((provider) => provider.GetRequiredService<CorrelationContext>());
        }
    }
}
