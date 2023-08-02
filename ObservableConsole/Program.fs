open System
open System.Runtime.InteropServices
open Microsoft.Extensions.Logging
open OpenTelemetry.Logs
open OpenTelemetry.Resources

let resourceBuilder =
    ResourceBuilder
        .CreateDefault()
        .AddService(
            "ObservableConsole",
            "ObservableConsoleNamespace",
            "1.0.0")
        .AddTelemetrySdk()
        .AddAttributes(dict[
            "host.name", Environment.MachineName
            "os.description", RuntimeInformation.OSDescription
            "deployment.environment", "local"])

let loggerFactory = LoggerFactory.Create(fun builder ->
    builder
        .AddOpenTelemetry(fun options ->
            options
                .SetResourceBuilder(resourceBuilder)
                .AddConsoleExporter() |> ignore
            options.IncludeFormattedMessage <- true
            options.IncludeScopes <- true
            options.ParseStateValues <- true
            ()) |> ignore
    ())

let logger = loggerFactory.CreateLogger<obj>();

logger.LogInformation(
    123,
    "Hello from {name} {price}.",
    "tomato",
    2.99)

printfn "Hello from F#"