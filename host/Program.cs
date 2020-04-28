using System.Net;
using System.Threading.Tasks;
using Orleans.Configuration;
using Orleans.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.DependencyInjection;

namespace OrleansSandbox.Host
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
                options.ServiceId = "HelloWorldApp";
              })
              .Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback);
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
