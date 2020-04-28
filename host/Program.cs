using System;
using System.Net;
using System.Threading.Tasks;
using Orleans.Configuration;
using Orleans.Hosting;
using Microsoft.Extensions.Logging;

namespace OrleansSandbox.Host
{
  class Program
  {
    static async Task<int> Main(string[] args)
    {
      try
      {
        var host = await StartSilo();
        Console.WriteLine("Press Enter to terminate...");
        Console.ReadLine();

        await host.StopAsync();

        return 0;
      }
      catch (Exception ex)
      {
        Console.WriteLine(ex);
        return 1;
      }
    }

    private static async Task<ISiloHost> StartSilo()
    {
      var builder = new SiloHostBuilder()
          .UseLocalhostClustering()
          .Configure<ClusterOptions>(options =>
          {
            options.ClusterId = "dev";
            options.ServiceId = "HelloWorldApp";
          })
          .Configure<EndpointOptions>(options => options.AdvertisedIPAddress = IPAddress.Loopback)
          .ConfigureLogging(logging => logging.AddConsole());

      var host = builder.Build();
      await host.StartAsync();
      return host;
    }
  }
}
