open OpenTelemetry
open OpenTelemetry.Metrics
open System

printfn "Hello from F#"

let meterProvider = Sdk.CreateMeterProviderBuilder().AddRuntimeInstrumentation().Build()

// Most of the process.runtime.dotnet.gc.* metrics are only available after the GC finished at least one collection.
GC.Collect(1);

// // The process.runtime.dotnet.exception.count metrics are only available after an exception has been thrown post OpenTelemetry.Instrumentation.Runtime initialization.
// try
// {
// throw new Exception("Oops!");
// }
// catch (Exception)
// {
// // swallow the exception
// }*/

Console.WriteLine(".NET Runtime metrics are available at http://localhost:9464/metrics, press any key to exit...")
Console.ReadKey(false) |> ignore