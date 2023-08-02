# special-octo-fiesta

f# + otel + elk

## resources used

* https://opentelemetry.io/docs/instrumentation/net/getting-started/
* https://learn.microsoft.com/en-us/dotnet/core/diagnostics/observability-with-otel
* https://github.com/open-telemetry/opentelemetry-dotnet-contrib/blob/main/examples/runtime-instrumentation/Program.cs
* https://github.com/open-telemetry/opentelemetry-dotnet/blob/main/docs/logs/getting-started/README.md
* https://www.twilio.com/blog/build-a-logs-pipeline-in-dotnet-with-opentelemetry

## features

### logs

#### console exporter

```bash
LogRecord.Timestamp:               2023-08-02T10:33:29.6551132Z
LogRecord.CategoryName:            object
LogRecord.LogLevel:                Information
LogRecord.FormattedMessage:        Hello from tomato 2.99.
LogRecord.Body:                    Hello from {name} {price}.
LogRecord.Attributes (Key:Value):
    name: tomato
    price: 2.99
    OriginalFormat (a.k.a Body): Hello from {name} {price}.
LogRecord.EventId:                 123

Resource associated with LogRecord:
host.name: 4d4ec2fca7df
os.description: Linux 5.15.49-linuxkit-pr #1 SMP PREEMPT Thu May 25 07:27:39 UTC 2023
deployment.environment: local
telemetry.sdk.name: opentelemetry
telemetry.sdk.language: dotnet
telemetry.sdk.version: 1.5.1
service.name: ObservableConsole
service.namespace: ObservableConsoleNamespace
service.version: 1.0.0
service.instance.id: f95e69ae-4277-4d7e-98d6-92147d86dd5c
```

## how to use

* `./start-development-environment.sh`
* `./build.sh`
* `./run.sh`

## additional notes

* there's also this nuget, possibly worth exploring in the future: `OpenTelemetry.Instrumentation.Process`