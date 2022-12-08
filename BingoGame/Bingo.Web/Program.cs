using System;
using Bingo.Domain.Models;
using Bingo.Domain.Services.Interfaces;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Bingo.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var webHost = CreateHostBuilder(args).Build();

            var gameService = webHost.Services.GetService<IGameService>();
            var settings = webHost.Services.GetService<IOptions<GameSettings>>();
            gameService.StartGame(settings.Value);
            gameService.AddPlayer("Test superman", settings.Value);

            webHost.Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
