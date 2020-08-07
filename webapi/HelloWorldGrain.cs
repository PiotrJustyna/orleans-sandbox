using System.Threading.Tasks;
using Orleans;

namespace Webapi
{
  public interface IHelloWorldGrain : IGrainWithIntegerKey
  {
    Task<string> SayHello(string name);
  }

  public class HelloWorldGrain : Grain, IHelloWorldGrain
  {
    public Task<string> SayHello(string name)
    {
      return Task.FromResult($"Hello, {name}!");
    }
  }
}