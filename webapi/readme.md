# readme

This is a simple hello world example, but this time we're using orleans with a web api host. The code illustrates two things:

* how to interface grains using web api controllers
* how to add newrelic observability

Newrelic is configured in the Dockerfile:

```
ENV CORECLR_ENABLE_PROFILING=1
ENV CORECLR_PROFILER={36032161-FFC0-4B61-B559-F6C5D41BAE5A}
ENV CORECLR_PROFILER_PATH=newrelic-netcore20-agent/libNewRelicProfiler.so
ENV CORECLR_NEWRELIC_HOME=newrelic-netcore20-agent/
ENV NEW_RELIC_LICENSE_KEY=[YOUR_LICENSE_KEY_HERE]
ENV NEW_RELIC_APP_NAME=orleans-sandbox
```

Additionally, the agent binaries are expected to be placed in `newrelic-netcore20-agent` directory. I removed those files not to unnecessarily distribute the agent.

## usage

This is a very straightforward, single-project example, so there's no real need for convenience scripts. Simply build and run the code.

The api can be tested e.g. with this command:

```
curl "http://localhost:5432/helloworld?name=Piotr"
```