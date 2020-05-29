# readme

Presence service adapted from this example: https://github.com/dotnet/orleans/tree/master/Samples/3.0/Presence

This is slightly more involved than the "hello world" example and deserves some high level overview. Here are the participating components:

* silo
* grains
  * player
    * get current game
    * join game
    * leave game
  * game
    * update game status - update list of players, update score
    * observe game updates - add an observer to collection of observers
    * unobserve game updates - add an observer to collection of observers
  * presence
    * heartbeat - `LoadGenerator` sends new scores through this method. Presence grain finds game grains identified by the `HeartbeatData` payload and updates the respective scores using the found grains.
* player watcher
  * obtain a player grain by a given ID
  * wait for that player grain to obtain current game
  * create `IGameObserver` reference and start observing game updates