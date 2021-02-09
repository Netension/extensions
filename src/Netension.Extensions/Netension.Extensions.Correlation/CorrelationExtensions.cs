using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Netension.Extensions.Correlation
{
    public static class CorrelationExtensions
    {
        public static IHostBuilder RegistrateCorrelation(this IHostBuilder builder)
        {
            return builder.ConfigureServices((context, services) =>
            {
                services.AddScoped<CorrelationContext>();
                services.AddScoped<ICorrelationAccessor>((provider) => provider.GetRequiredService<CorrelationContext>());
                services.AddScoped<ICorrelationMutator>((provider) => provider.GetRequiredService<CorrelationContext>());
            });
        }
    }
}
