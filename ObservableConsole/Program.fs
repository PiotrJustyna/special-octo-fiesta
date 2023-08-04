open System
open System.Threading.Tasks
open Microsoft.Extensions.DependencyInjection
open Microsoft.Extensions.Hosting
open Microsoft.Extensions.Logging
open Elastic.Extensions.Logging

type Worker(logger : ILogger<Worker>) =
    inherit BackgroundService()
    let _logger = logger
    override bs.ExecuteAsync stoppingToken =
        let f : Async<unit> = async {
            while not stoppingToken.IsCancellationRequested do
                _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now)
                do! Async.Sleep(1000)
        }
        // ExecuteAsync needs to return a task, hence up-cast from Task<unit> to plain Task.
        Async.StartAsTask f :> Task

let CreateHostBuilder argv : IHostBuilder =
    let builder = Host.CreateDefaultBuilder(argv)

    builder
        .ConfigureLogging(fun (loggingBuilder: ILoggingBuilder) -> loggingBuilder.AddElasticsearch() |> ignore)
        .ConfigureServices(fun (services: IServiceCollection) -> services.AddHostedService<Worker>() |> ignore)

[<EntryPoint>]
let main argv =
    let hostBuilder = CreateHostBuilder argv
    hostBuilder.Build().Run()
    0 // return an integer exit code