# notes
- [notes](#notes)
  - [resources](#resources)
  - [turns](#turns)
  - [persistence](#persistence)
  - [timers](#timers)
  - [runtime](#runtime)
  - [distributed directory](#distributed-directory)
  - [strong isolation](#strong-isolation)
  - [cooperative multitasking](#cooperative-multitasking)
  - [serialization](#serialization)

## resources

https://www.microsoft.com/en-us/research/wp-content/uploads/2016/02/Orleans-MSR-TR-2014-41.pdf

## turns

* a turn can be  a method invocation or a  closure executed on resolution of a promise
* turns of different activations may be executed in parallel, but each activation executes only one turn at a time
* interleaving of turns for multiple requests to the same activation (avoided by orleans by default) - an  activation  does  not receive  a  new  request  until  all  promises  created  during the processing of the current request have been resolved and all of their associated closures executed `[Reentrant]`

## persistence

* `IState`
* `ActorBase<IState>`
* to checkpoint an actor's persistent state: `this.State.WriteStateAsync()`
* :warning: actors don't seem to use the `async/await` pattern
* persistence providers

## timers

* transient timers
* reminders

## runtime

* cluster of servers
  * server
    * container process - creates and hosts actor activations
      * subsystem 1 - messaging: one tcp connection between each pair of servers, multiplexing messages between actors on those connected servers
      * subsystem 2 - hosting: decides where to place activations and manages their lifecycles
      * subsystem 3 - execution: runs actors' code on a set of compute threads with the single-threaded reentrancy guarantees

## distributed directory

* flexible placement (no need for consistent hashing or range-based partitioning)
* implementation: one-hop distribuetd hash table
* server
  * partition of the directory
    * actors are assigned to the partiton using consistent hashing
* single-activation constraint is enforced by the directory

## strong isolation

* method-call arguments and the return value are deep copied synchronously between actor calls, even if the two actors happen to reside on the same machine, to guarantee immutability of the sent data
* Immutable<T>

## cooperative multitasking

* cooperative multitasking -  means  that  once  started,  an  application  turn  runs  to  completion,  without  interruption
* weakness of cooperative multitaskingis that a poorly behaved component can take up an  entire processor, degrading the performance of other components.

## serialization

* orleans allows any data type and maintains object identity through the serializer so  that two pointers to the same object still point to the same object after deserialization