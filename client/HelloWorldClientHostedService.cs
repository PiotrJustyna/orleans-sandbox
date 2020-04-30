using System;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Hosting;
using Orleans;
using OrleansSandbox.Interfaces;

namespace OrleansSandbox.Client
{
  public class HelloWorldClientHostedService : IHostedService
  {
    private readonly IClusterClient _client;

    public HelloWorldClientHostedService(IClusterClient client)
    {
      this._client = client;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
      var friend = this._client.GetGrain<IHello>(0);
      var response = await friend.SayHello("Good morning, my friend!");
      Console.WriteLine($"{response}");
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
  }
}