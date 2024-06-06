using BlazorClientesNet8.Client.Services;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Components.WebAssembly.Hosting;
using MudBlazor.Services;

var builder = WebAssemblyHostBuilder.CreateDefault(args);

builder.Services.AddScoped<IClienteRepository, ClienteService>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaService>();

builder.Services.AddScoped<IColaboradorRepository, ColaboradorService>();

builder.Services.AddScoped<ITipoContratacaoRepository,TipoContratacaoService>();

builder.Services.AddScoped<ILocalidadeRepository, LocalidadeService>();

builder.Services.AddScoped<IDepartamentoRepository, DepartamentoService>();


builder.RootComponents.Add<HeadOutlet>("head::after");

builder.Services.AddMudServices().AddMudBlazorDialog().AddMudPopoverService();



builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.HostEnvironment.BaseAddress),
});


await builder.Build().RunAsync();