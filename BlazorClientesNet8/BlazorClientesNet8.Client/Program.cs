using BlazorClientesNet8.Client.Services;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddMudServices();

builder.Services.AddScoped<IClienteRepository, ClienteService>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaService>();

builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});

await builder.Build().RunAsync();