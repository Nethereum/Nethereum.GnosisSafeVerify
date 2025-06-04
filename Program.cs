using System.Net.Http.Json;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;
using Nethereum.GnosisValidator;
using Serilog;
using Nethereum.Blazor;
using Nethereum.EIP6963WalletInterop;
using Nethereum.Blazor.Storage;
using Nethereum.UI;
using Microsoft.AspNetCore.Components.Authorization;
using Nethereum.Blazor.EIP6963WalletInterop;


var builder = WebAssemblyHostBuilder.CreateDefault(args);


if (!builder.RootComponents.Any())
{
    builder.RootComponents.Add<App>("#app");
    builder.RootComponents.Add<HeadOutlet>("head::after");
}

builder.Services.AddMudServices();

builder.Services.AddAuthorizationCore();
builder.Services.AddSingleton<IEIP6963WalletInterop, EIP6963WalletBlazorInterop>();
builder.Services.AddSingleton<EIP6963WalletHostProvider>();
builder.Services.AddSingleton<LocalStorageHelper>();

//Add eip as the selected ethereum host provider
builder.Services.AddSingleton(services =>
{
    var walletHostProvider = services.GetService<EIP6963WalletHostProvider>();
    var selectedHostProvider = new SelectedEthereumHostProviderService();
    selectedHostProvider.SetSelectedEthereumHostProvider(walletHostProvider);
    return selectedHostProvider;
});


builder.Services.AddSingleton<AuthenticationStateProvider, EthereumAuthenticationStateProvider>();


Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Verbose()
    .WriteTo.BrowserConsole()
    .CreateLogger();

var app = builder.Build();
    
await app.RunAsync();

