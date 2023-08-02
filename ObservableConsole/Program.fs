open Microsoft.Extensions.Logging
open OpenTelemetry.Logs

let loggerFactory = LoggerFactory.Create(fun builder ->
    builder.AddOpenTelemetry(fun options ->
        options.AddConsoleExporter() |> ignore
        ()) |> ignore
    ())

let logger = loggerFactory.CreateLogger<obj>();

logger.LogInformation(
    123,
    "Hello from {name} {price}.",
    "tomato",
    2.99)

printfn "Hello from F#"