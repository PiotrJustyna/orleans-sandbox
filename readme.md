- [orleans sandbox.](#orleans-sandbox)
  - [build](#build)
  - [run](#run)
  - [examples](#examples)

# orleans sandbox.

A sandbox I use to experiment with orleans. Examples here were originally found in:

https://github.com/dotnet/orleans/tree/master/Samples

and optionally modified for simplicity. Tutorials found in the documentation:

https://dotnet.github.io/orleans/Documentation/tutorials_and_samples/index.html

Samples can be opened and built both locally and in remote containers using e.g. vs code and the `remote-containers` plugin (which is the recommended option).

## build

To build the code locally or in a remote container, execute:

```bash
dotnet build
```

or [ctrl/command]+shift+b or whatever shortcut you use to build your code.

## run

To run the code locally or in a remote container, execute:

```bash
dotnet run
```

or F5, [ctrl/command]+F5 or whatever shortcut you use to run/debug your code.

## examples

* [hello-world](./hello-world/)

* [presence](./presence/)