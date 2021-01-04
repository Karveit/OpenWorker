using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using ow.Framework.Extensions;
using ow.Framework.IO.Lan.Extensions;
using ow.Framework.IO.Network.Sync.Extensions;
using ow.Service.Gate.Game;
using ow.Service.Gate.Game.Repository;
using ow.Service.Gate.Network;

namespace ow.Service.Gate
{
    public static class Program
    {
        public static void Main(string[] args) => CreateHostBuilder(args).Build().Run();

        public static IHostBuilder CreateHostBuilder(string[] args) => Host
            .CreateDefaultBuilder(args)
            .ConfigureAppConfiguration((context, config) => config
                .AddFramework(context))
            .ConfigureServices((context, services) => services
                .AddHostedService<Worker>()
                .AddSingleton<BinTables>()
                .AddSingleton<DistrictRepository>()
                .AddSingleton<GateInstance>()
                .AddTransient<Session>()
                .AddTransient<Server>()
                .AddAccountContext(context)
                .AddCharacterContext(context)
                .AddItemContext(context)
                .AddFramework()
                .AddLan());
    }
}