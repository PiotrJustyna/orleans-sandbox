using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans;
using OrleansSandbox.Interfaces;

namespace OrleansSandbox.Lib
{
  public class HelloGrain : Orleans.Grain, IHello
  {
    private readonly TimeSpan _dueTime = TimeSpan.FromSeconds(3);
    private readonly TimeSpan _period = TimeSpan.FromSeconds(1);
    private readonly ILogger _logger;
    private IDisposable _timer;
    private byte _ticksNeeded = 5;

    public HelloGrain(ILogger<HelloGrain> logger)
    {
      _logger = logger;
    }

    public override async Task OnActivateAsync()
    {
      _timer = RegisterTimer(
        asyncCallback: TimerCallback,
        state: null,
        dueTime: _dueTime,
        period: _period);

      _logger.LogInformation($"Timer registered.");

      await base.OnActivateAsync();
    }

    private Task TimerCallback(object argument)
    {
      if(_ticksNeeded > 0)
      {
        _ticksNeeded--;

        _logger.LogInformation($"Hello grain timer tick.");
      }
      else
      {
        _timer.Dispose();

        _logger.LogInformation($"Timer no longer needed.");
      }

      return Task.CompletedTask;
    }

    Task<string> IHello.SayHello(string greeting)
    {
      // 2020-05-11 PJ:
      // Only use the (console) logger for low numbers of client messages.
      _logger.LogInformation($"SayHello message received: greeting = '{greeting}'");

      return Task.FromResult($"You said: '{greeting}', I say: Hello!");
    }
  }
}