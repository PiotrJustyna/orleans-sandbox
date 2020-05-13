using System.Threading.Tasks;
using Orleans;
using OrleansSandbox.Grains.Interfaces.Models;

namespace OrleansSandbox.Grains.Interfaces
{
  public interface IGameGrain : IGrainWithGuidKey
  {
    Task UpdateGameStatusAsync(GameStatus status);
    Task ObserveGameUpdatesAsync(IGameObserver observer);
    Task UnobserveGameUpdatesAsync(IGameObserver observer);
  }
}