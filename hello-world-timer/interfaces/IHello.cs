using System.Threading.Tasks;

namespace OrleansSandbox.Interfaces
{
  public interface IHello : Orleans.IGrainWithIntegerKey
  {
    Task<string> SayHello(string greeting);
  }
}
