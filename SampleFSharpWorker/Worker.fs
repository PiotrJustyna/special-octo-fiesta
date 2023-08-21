namespace SampleFSharpWorker

module Workers =

  open System
  open System.Threading
  open System.Threading.Tasks
  open Microsoft.Extensions.Hosting
  open Microsoft.Extensions.Logging

  type Worker(logger : ILogger<Worker>) =
    inherit BackgroundService()

    let _logger = logger

    override _.ExecuteAsync(stoppingToken : CancellationToken) =
      let f : Async<unit> = async {
        while not stoppingToken.IsCancellationRequested do
          _logger.LogInformation("Worker running at: {time}", DateTimeOffset.Now)
          do! Async.Sleep(1000)
      }
      Async.StartAsTask f :> Task