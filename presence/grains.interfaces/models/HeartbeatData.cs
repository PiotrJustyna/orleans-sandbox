using System;
using System.Linq;
using System.Text;
using Orleans.Concurrency;

namespace OrleansSandbox.Grains.Interfaces.Models
{
  [Immutable]
  public class HeartbeatData
  {
    public Guid GameKey { get; }

    public GameStatus Status { get; }

    public HeartbeatData(
      Guid gameKey,
      GameStatus status)
    {
      GameKey = gameKey;
      Status = status;
    }

    public override string ToString()
    {
      var builder = new StringBuilder();
      builder.Append($"Heartbeat:Game={GameKey}");

      // 2020-05-13 PJ:
      // At the time of writing this, AppendJoin on StringBuilder
      // is not available in .net standard sadly,
      // which forcing this library and all libraries consuming it,
      // to be of type .net core.
      // Reference: https://docs.microsoft.com/en-us/dotnet/api/system.text.stringbuilder.appendjoin?view=netcore-3.1&viewFallbackFrom=netstandard-2.0
      builder.AppendJoin(
        ',',
        Status.PlayerKeys.Select((item, idx) => $"Player{idx + 1}={item}"));

      builder.Append($",Score={Status.Score}");

      return builder.ToString();
    }

    public HeartbeatData WithNewScore(string newScore) =>
      new HeartbeatData(
        GameKey,
        Status.WithNewScore(newScore));
  }
}