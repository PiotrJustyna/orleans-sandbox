using System;
using System.Collections.Immutable;
using Orleans.Concurrency;

namespace OrleansSandbox.Grains.Interfaces.Models
{
  [Immutable]
  public class GameStatus
  {
    public ImmutableHashSet<Guid> PlayerKeys { get; }

    public string Score { get; }

    public GameStatus(
      ImmutableHashSet<Guid> playerKeys,
      string score)
    {
      PlayerKeys = playerKeys;
      Score = score;
    }

    public GameStatus WithNewScore(string newScore) =>
      new GameStatus(
        PlayerKeys,
        newScore);

    public static GameStatus Empty { get; } =
      new GameStatus(
        ImmutableHashSet<Guid>.Empty,
        string.Empty);
  }
}