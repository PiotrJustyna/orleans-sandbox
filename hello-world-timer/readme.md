# readme

This is a variation of the hello world example and it focuses on using timers. What happens in this example is:

* only one "hello world" message gets sent by the client
* upon `HelloGrain` activation ("hello world" message received), two timers get started:
  * `_timer1` - 3 seconds period
  * `_timer2` - 1 second period
  
  both kick off at the same time (3 seconds delay before the first tick).
* both timers tick 5 times before they stop (get disposed)

What this example also illustrates is the fact that:

* there can be more than one timer per grain
* even though `_timer2`'s period is set to 1 second, it still effectively ticks every 3 seconds due to a 2 second delay in its callback's execution - as a result, both timers tick at the same perceived time (but the callbacks are not executed in concurrent activation tunrs, see here: [Each invocation of asyncCallback is delivered to an activation on a separate turn and will never run concurrently with other turns on the same activation](https://dotnet.github.io/orleans/Documentation/grains/timers_and_reminders.html#timer-usage).)

This example illustrates the following part of the documentation: https://dotnet.github.io/orleans/Documentation/grains/timers_and_reminders.html#timer-description

```
info: OrleansSandbox.Lib.HelloGrain[0]
      SayHello message received: greeting = 'Good morning, my friend!'
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:29 PM - Hello grain timer 2 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:29 PM - Hello grain timer 1 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:32 PM - Hello grain timer 2 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:32 PM - Hello grain timer 1 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:35 PM - Hello grain timer 2 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:35 PM - Hello grain timer 1 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:38 PM - Hello grain timer 2 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:38 PM - Hello grain timer 1 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:41 PM - Hello grain timer 2 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:41 PM - Hello grain timer 1 tick.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:44 PM - Timer 2 no longer needed.
info: OrleansSandbox.Lib.HelloGrain[0]
      11:12:44 PM - Timer 1 no longer needed.
```