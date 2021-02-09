using Microsoft.Extensions.DependencyInjection;
using Netension.Extensions.Correlation;

namespace Microsoft.Extensions.Hosting
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
