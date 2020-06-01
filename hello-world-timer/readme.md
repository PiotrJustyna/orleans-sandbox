# readme

This is a variation of the hello world example and it focuses on using timers. What happens in this example is:

* only one "hello world" message gets sent by the client
* upon `HelloGrain` activation ("hello world" message received), a timer gets started
* timer waits 3 seconds before its first tick
* timer period is set to 1 second
* timer ticks 5 times before it stops (gets disposed)

This example illustrates the following part of the documentation: https://dotnet.github.io/orleans/Documentation/grains/timers_and_reminders.html#timer-description

```
info: Orleans.Hosting.SiloHostedService[0]
      Orleans Silo started.
info: Orleans.Runtime.Messaging.Gateway[101301]
      Recorded opened connection from endpoint 127.0.0.1:53344, client ID *cli/198e3ebd.
info: Microsoft.Orleans.Networking[0]
      Starting to process messages from remote endpoint 127.0.0.1:53344 to local endpoint 127.0.0.1:30000
info: Microsoft.Orleans.Networking[0]
      Starting to process messages from local endpoint 127.0.0.1:30000 to remote endpoint 127.0.0.1:53344
info: OrleansSandbox.Lib.HelloGrain[0]
      Timer registered.
info: OrleansSandbox.Lib.HelloGrain[0]
      SayHello message received: greeting = 'Good morning, my friend!'
info: OrleansSandbox.Lib.HelloGrain[0]
      Hello grain timer tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      Hello grain timer tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      Hello grain timer tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      Hello grain timer tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      Hello grain timer tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      Timer no longer needed.
```