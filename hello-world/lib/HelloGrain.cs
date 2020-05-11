using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using OrleansSandbox.Interfaces;

namespace OrleansSandbox.Lib
{
  public class HelloGrain : Orleans.Grain, IHello
  {
    private readonly ILogger logger;

    public HelloGrain(ILogger<HelloGrain> logger)
    {
      this.logger = logger;
    }

    Task<string> IHello.SayHello(string greeting)
    {
      // 2020-05-11 PJ:
      // Only use the (console) logger for low numbers of client messages.
      // logger.LogInformation($"SayHello message received: greeting = '{greeting}'");
      return Task.FromResult($"You said: '{greeting}', I say: Hello!");
    }
  }
}