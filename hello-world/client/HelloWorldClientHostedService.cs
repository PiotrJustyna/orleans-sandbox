using System;
using System.Collections.Generic;
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
      _client = client;
    }

    public async Task StartAsync(CancellationToken cancellationToken)
    {
      var friend = this._client.GetGrain<IHello>(0);
      var tasks = new List<Task>();

      Console.WriteLine($"Hello world tasks starting...");

      for (UInt32 i = 0; i < 10000; i++)
      {
        tasks.Add(friend.SayHello("Good morning, my friend!"));
      }

      await Task.WhenAll(tasks);

      Console.WriteLine($"All hello world tasks finished.");
    }

    public Task StopAsync(CancellationToken cancellationToken) => Task.CompletedTask;
  }
}