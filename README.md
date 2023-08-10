# special-octo-fiesta

f# + otel + elk

## resources used

* https://opentelemetry.io/docs/instrumentation/net/getting-started/
* https://learn.microsoft.com/en-us/dotnet/core/diagnostics/observability-with-otel
* https://github.com/open-telemetry/opentelemetry-dotnet-contrib/blob/main/examples/runtime-instrumentation/Program.cs
* https://github.com/open-telemetry/opentelemetry-dotnet/blob/main/docs/logs/getting-started/README.md
* https://www.twilio.com/blog/build-a-logs-pipeline-in-dotnet-with-opentelemetry
* https://www.elastic.co/guide/en/enterprise-search/current/logging-view-query-logs.html
* https://github.com/ty-elastic/otel-logging - it's for java, but still useable
* https://github.com/open-telemetry/opentelemetry-dotnet/blob/main/src/OpenTelemetry.Exporter.OpenTelemetryProtocol/README.md - logs are TODO :D
* https://learn.microsoft.com/en-us/dotnet/core/extensions/logging-providers
* https://www.youtube.com/watch?v=0acSdHJfk64
* https://www.elastic.co/blog/getting-started-with-the-elastic-stack-and-docker-compose
* https://github.com/elastic/ecs-dotnet/blob/main/examples/console-with-extensions-logging/docker-compose.yml
* https://www.youtube.com/watch?v=zp6A5QCW_II
* https://www.elastic.co/blog/3-models-logging-opentelemetry-elastic
  * good presentation material
  * opentelemetry includes provisions for span events
  * elastic common schema - but that does not apply to logs collected via otlp instrumentation. In that case, logs remain formatted in otel log semantics. But ECS is to become the standard for log semantics [2023-04-18 article](https://www.elastic.co/blog/ecs-elastic-common-schema-otel-opentelemetry-announcement)
  * Conversion to ECS happens within Elastic keeping log data vendor-agnostic until ingestion
* https://opentelemetry.io/docs/instrumentation/#status-and-releases - opentelemetry instrumentation library seems to be stable, especially for dotnet

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