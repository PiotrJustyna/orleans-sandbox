- [orleans sandbox.](#orleans-sandbox)
  - [examples](#examples)

# orleans sandbox.

A sandbox I use to experiment with orleans. Examples here were originally found in:

https://github.com/dotnet/orleans/tree/master/Samples

and optionally modified for simplicity. Tutorials found in the documentation:

https://dotnet.github.io/orleans/Documentation/tutorials_and_samples/index.html

Samples can be opened and built both locally and in remote containers using e.g. vs code and the `remote-containers` plugin (which is the recommended option).

All convenience scripts I use in the sandbox are shell scripts (`*.sh`). If you're not sure how to execute them on Windows, please consider using [git bash](https://git-scm.com/).

Typically, there is more than one project per example to build and execute, so there are convenience scripts which should help build everything relatively easily:

* `build-*.sh`

Where `build-all.sh`, as the name suggests, builds all projects relevant to any given example.

## examples

* [hello-world](./hello-world/)

* [hello-world-timer](./hello-world-timer/)

* [presence](./presence/)