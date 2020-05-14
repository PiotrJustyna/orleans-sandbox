using System;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans;
using OrleansSandbox.Shared;

namespace OrleansSandbox.LoadGenerator
{
  public class Program
  {
    public static Task Main(string[] args)
    {
      return new HostBuilder()
        .ConfigureServices(services =>
        {
          services.AddSingleton<ClusterClientHostedService>();
          services.AddSingleton<IHostedService>(_ => _.GetService<ClusterClientHostedService>());
          services.AddSingleton(_ => _.GetService<ClusterClientHostedService>().Client);

          services.AddSingleton<IHostedService, LoadGeneratorHostedService>();
        })
        .ConfigureLogging(builder =>
        {
          builder.AddConsole();
        })
        .RunConsoleAsync();
    }
  }
}
