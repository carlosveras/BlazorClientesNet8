using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorClientesNet8.Client.Services;

public class ColaboradorService : IColaboradorRepository
{
    private readonly HttpClient httpClient;
    private readonly JsonSerializerOptions _options;

    public ColaboradorService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        _options = new JsonSerializerOptions { 
            PropertyNameCaseInsensitive = true 
        };
    }


    public async Task<List<Colaborador>> GetAllColaboradoresAsync()
    {
        var colaboradores = await httpClient.GetAsync("api/Colaborador/Colaboradores");
        var response = await colaboradores.Content.ReadFromJsonAsync<List<Colaborador>>();
        return response!;
    }


    public async Task<Colaborador> AddColaboradorAsync(Colaborador model)
    {
        var colaborador = await httpClient.PostAsJsonAsync("api/Colaborador/Add-Colaborador", model);
        var response = await colaborador.Content.ReadFromJsonAsync<Colaborador>();
        return response!;
    }

    public async Task<Colaborador> DeleteColaboradorAsync(int colaboradorId)
    {
        var colaborador = await httpClient.DeleteAsync($"api/Cliente/Delete-Colaborador/{colaboradorId}");
        var response = await colaborador.Content.ReadFromJsonAsync<Colaborador>();
        return response!;
    }

    public async Task<Colaborador> GetColaboradorByIdAsync(int colaboradorId)
    {
        var colaborador = await httpClient.GetAsync($"api/Colaborador/Colaborador/{colaboradorId}");
        var response = await colaborador.Content.ReadFromJsonAsync<Colaborador>();
        return response!;
    }

    public async Task<Colaborador> UpdateColaboradorAsync(Colaborador model)
    {
        var colaborador = await httpClient.PutAsJsonAsync("api/Colaborador/Update-Colaborador", model);
        var response = await colaborador.Content.ReadFromJsonAsync<Colaborador>();
        return response!;
    }
}
