using Bingo.Domain.Services;
using Bingo.Domain.Services.Interfaces;
using Microsoft.Extensions.DependencyInjection;

namespace Bingo.Web.DI
{
    public static class DomainServicesExtensions
    {
        public static void RegisterDomainServices(this IServiceCollection services)
        {
            services.AddSingleton<IGameService, GameService>();
            services.AddSingleton<IBoardService, BoardService>();
        }
    }
}
