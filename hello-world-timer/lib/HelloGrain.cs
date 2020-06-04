using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans;
using OrleansSandbox.Interfaces;

namespace OrleansSandbox.Lib
{
  public class HelloGrain : Orleans.Grain, IHello
  {
    private readonly ILogger _logger;
    private readonly TimeSpan _dueTime = TimeSpan.FromSeconds(3);
    private readonly TimeSpan _period1 = TimeSpan.FromSeconds(1);
    private IDisposable _timer1;
    private byte _ticksNeeded1 = 5;
    private readonly TimeSpan _period2 = TimeSpan.FromSeconds(3);
    private IDisposable _timer2;
    private byte _ticksNeeded2 = 5;

    public HelloGrain(ILogger<HelloGrain> logger)
    {
      _logger = logger;
    }

    public override async Task OnActivateAsync()
    {
      _timer1 = RegisterTimer(
        asyncCallback: Timer1Callback,
        state: null,
        dueTime: _dueTime,
        period: _period1);

      _timer2 = RegisterTimer(
        asyncCallback: Timer2Callback,
        state: null,
        dueTime: _dueTime,
        period: _period2);

      _logger.LogInformation($"Timers registered.");

      await base.OnActivateAsync();
    }

    private async Task Timer1Callback(object argument)
    {
      if(_ticksNeeded1 > 0)
      {
        _ticksNeeded1--;

        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()} - Hello grain timer 1 tick.");

        await Task.Delay(2000);
      }
      else
      {
        _timer1.Dispose();

        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()} - Timer 1 no longer needed.");
      }
    }

    private Task Timer2Callback(object argument)
    {
      if(_ticksNeeded2 > 0)
      {
        _ticksNeeded2--;

        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()} - Hello grain timer 2 tick.");
      }
      else
      {
        _timer2.Dispose();

        _logger.LogInformation($"{DateTime.Now.ToLongTimeString()} - Timer 2 no longer needed.");
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