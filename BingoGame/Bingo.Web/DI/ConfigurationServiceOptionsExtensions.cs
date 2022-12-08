using Bingo.Domain.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Bingo.Web.DI
{
    public static class ConfigurationServiceOptionsExtensions
    {
        public static void RegisterOptions(this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<GameSettings>(configuration.GetSection("GameSettings"));
        }
    }
}
