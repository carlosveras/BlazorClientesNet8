using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorClientesNet8.Client.Services;
public class DepartamentoService : IDepartamentoRepository
{
    private readonly HttpClient httpClient;
    private readonly JsonSerializerOptions _options;

    public DepartamentoService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        _options = new JsonSerializerOptions { 
            PropertyNameCaseInsensitive = true 
        };
    }
    public async Task<Departamento> AddDepartamentoAsync(Departamento model)
    {
        var departamento = await httpClient.PostAsJsonAsync("api/Departamento/Add-Departamento", model);
        var response = await departamento.Content.ReadFromJsonAsync<Departamento>();
        return response!;
    }

    public async Task<Departamento> DeleteDepartamentoAsync(int departamentoId)
    {
        var departamento = await httpClient.DeleteAsync($"api/Departamento/Delete-Departamento/{departamentoId}");
        var response = await departamento.Content.ReadFromJsonAsync<Departamento>();
        return response!;
    }

    public async Task<List<Departamento>> GetAllDepartamentosAsync()
    {
        var departamentos = await httpClient.GetAsync("api/Departamento/Departamentos");
        var response = await departamentos.Content.ReadFromJsonAsync<List<Departamento>>();
        return response!;
    }

    public async Task<Departamento> GetDepartamentoByIdAsync(int departamentoId)
    {
        var departamento = await httpClient.GetAsync($"api/Departamento/Departamento/{departamentoId}");
        var response = await departamento.Content.ReadFromJsonAsync<Departamento>();
        return response!;
    }

    public async Task<Departamento> UpdateDepartamentoAsync(Departamento model)
    {
        var departamento = await httpClient.PutAsJsonAsync("api/Departamento/Update-Departamento", model);
        var response = await departamento.Content.ReadFromJsonAsync<Departamento>();
        return response!;
    }
}
