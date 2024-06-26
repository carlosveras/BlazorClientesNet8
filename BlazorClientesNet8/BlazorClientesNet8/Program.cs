using BlazorClientesNet8.Context;
using BlazorClientesNet8.Repositories;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;
using MudBlazor.Services;
using BlazorClientesNet8.Components;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents().AddInteractiveServerComponents()
                .AddInteractiveWebAssemblyComponents();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ClienteContext>(opt =>
                   opt.UseSqlServer(connectionString));

builder.Services.AddScoped<IClienteRepository, ClienteRepository>();

builder.Services.AddScoped<ICategoriaRepository, CategoriaRepository>();

builder.Services.AddScoped<IColaboradorRepository, ColaboradorRepository>();

builder.Services.AddScoped<ITipoContratacaoRepository, TipoContratacaoRepository>();

builder.Services.AddScoped<IDepartamentoRepository, DepartamentoRepository>();

builder.Services.AddScoped<ILocalidadeRepository, LocalidadeRepository>();


builder.Services.AddScoped(http => new HttpClient
{
    BaseAddress = new Uri(builder.Configuration.GetSection("BaseAddress").Value!)
});

//builder.Services.AddMudServices();
builder.Services.AddMudServices().AddMudBlazorDialog().AddMudPopoverService();



var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseWebAssemblyDebugging();
}
else
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode()
    .AddInteractiveWebAssemblyRenderMode()
    //.AddAdditionalAssemblies(typeof(Counter).Assembly);
    .AddAdditionalAssemblies(typeof(BlazorClientesNet8.Client._Imports).Assembly);

app.Run();
