using System.Threading.Tasks;
using Orleans;

namespace OrleansSandbox.Grains.Interfaces
{
  /// <summary>
  /// Defines an interface for sending binary updates without knowing the specific game ID.
  /// Simulates what game consoles do when they send data to the cloud.
  /// </summary>
  public interface IPresenceGrain : IGrainWithIntegerKey
  {
    Task HeartbeatAsync(byte[] data);
  }
}