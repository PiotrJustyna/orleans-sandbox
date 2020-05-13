using System.Net;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Orleans;
using Orleans.Configuration;
using Orleans.Hosting;
using OrleansSandbox.Grains;

namespace OrleansSandbox.Silo
{
  class Program
  {
    public static Task Main(string[] args)
    {
      return new HostBuilder()
          .UseOrleans(builder =>
          {
            builder
              .UseLocalhostClustering()
              .Configure<ClusterOptions>(options =>
              {
                options.ClusterId = "dev";
                options.ServiceId = "PresenceApp";
              })
              .Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback)
              .ConfigureApplicationParts(parts =>
                parts
                  .AddApplicationPart(typeof(GameGrain).Assembly)
                  .WithReferences())
              .AddMemoryGrainStorage(name: "ArchiveStorage");
          })
          .ConfigureServices(services =>
          {
            services.Configure<ConsoleLifetimeOptions>(options =>
              {
                options.SuppressStatusMessages = true;
              });
          })
          .ConfigureLogging(builder =>
          {
            builder.AddConsole();
          })
          .RunConsoleAsync();
    }
  }
}
