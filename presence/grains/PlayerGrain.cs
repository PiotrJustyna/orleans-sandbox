using System;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;
using Orleans;
using OrleansSandbox.Grains.Interfaces;

namespace OrleansSandbox.Grains
{
  /// <summary>
  /// Represents an individual player that may or may not be in a game at any point in time.
  /// </summary>
  public class PlayerGrain : Grain, IPlayerGrain
  {
    private readonly ILogger<PlayerGrain> _logger;

    private IGameGrain currentGame;

    private Guid _grainKey => this.GetPrimaryKey();

    public PlayerGrain(ILogger<PlayerGrain> logger)
    {
      _logger = logger;
    }

    public Task<IGameGrain> GetCurrentGameAsync() =>
      Task.FromResult(currentGame);

    /// <summary>
    /// Game grain calls this method to notify that the player has joined the game.
    /// </summary>
    public Task JoinGameAsync(IGameGrain game)
    {
      currentGame = game;

      _logger.LogInformation(
        "Player {@PlayerKey} joined game {@GameKey}",
        _grainKey,
        game.GetPrimaryKey());

      return Task.CompletedTask;
    }

    /// <summary>
    /// Game grain calls this method to notify that the player has left the game.
    /// </summary>
    public Task LeaveGameAsync(IGameGrain game)
    {
      currentGame = null;

      _logger.LogInformation(
        "Player {@PlayerKey} left game {@GameKey}",
        _grainKey,
        game.GetPrimaryKey());

      return Task.CompletedTask;
    }
  }
}