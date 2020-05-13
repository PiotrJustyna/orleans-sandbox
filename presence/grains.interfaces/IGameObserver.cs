using Orleans;

namespace OrleansSandbox.Grains.Interfaces
{
  public interface IGameObserver : IGrainObserver
  {
    void UpdateGameScore(string score);
  }
}