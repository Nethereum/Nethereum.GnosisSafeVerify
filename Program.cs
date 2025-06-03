using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Nethereum.GnosisValidator;
using Serilog;

var builder = WebAssemblyHostBuilder.CreateDefault(args);


if (!builder.RootComponents.Any())
{
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");
}

builder.Services.AddMudServices();



Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .WriteTo.BrowserConsole()
    .CreateLogger();

await builder.Build().RunAsync();

