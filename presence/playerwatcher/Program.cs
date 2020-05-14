using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using OrleansSandbox.Grains.Interfaces;
using OrleansSandbox.Shared;

namespace OrleansSandbox.PlayerWatcher
{
  public class Program
  {
    public static Task Main(string[] args)
    {
      return new HostBuilder()
      .ConfigureServices(services =>
      {
        services.AddTransient<IGameObserver, LoggerGameObserver>();

        services.AddSingleton<ClusterClientHostedService>();
        services.AddSingleton<IHostedService>(_ => _.GetService<ClusterClientHostedService>());
        services.AddSingleton(_ => _.GetService<ClusterClientHostedService>().Client);

        services.AddSingleton<IHostedService, PlayerWatcherHostedService>();
      })
      .ConfigureLogging(builder =>
      {
        builder.AddConsole();
      })
      .RunConsoleAsync();
    }
  }
}