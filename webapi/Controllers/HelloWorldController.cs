using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Orleans;

namespace Webapi.Controllers
{
  [ApiController]
  [Route("[controller]")]
  public class HelloWorldController : ControllerBase
  {
    private readonly IHelloWorldGrain _grain;

    public HelloWorldController(IGrainFactory client)
    {
      _grain = client.GetGrain<IHelloWorldGrain>(0);
    }

    [HttpGet]
    public async Task<string> Get(string name)
    {
      return await _grain.SayHello(name);
    }
  }
}
