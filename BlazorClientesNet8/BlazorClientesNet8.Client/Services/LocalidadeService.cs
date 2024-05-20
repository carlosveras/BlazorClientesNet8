using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorClientesNet8.Client.Services;
public class LocalidadeService : ILocalidadeRepository
{
    private readonly HttpClient httpClient;
    private readonly JsonSerializerOptions _options;

    public LocalidadeService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        _options = new JsonSerializerOptions { 
            PropertyNameCaseInsensitive = true 
        };
    }
    public async Task<Localidade> AddLocalidadeAsync(Localidade model)
    {
        var localidade = await httpClient.PostAsJsonAsync("api/Localidade/Add-Localidade", model);
        var response = await localidade.Content.ReadFromJsonAsync<Localidade>();
        return response!;
    }

    public async Task<Localidade> DeleteLocalidadeAsync(int localidadeId)
    {
        var localidade = await httpClient.DeleteAsync($"api/Localidade/Delete-Localidade/{localidadeId}");
        var response = await localidade.Content.ReadFromJsonAsync<Localidade>();
        return response!;
    }

    public async Task<List<Localidade>> GetAllLocalidadesAsync()
    {
        var localidades = await httpClient.GetAsync("api/Localidade/Localidades");
        var response = await localidades.Content.ReadFromJsonAsync<List<Localidade>>();
        return response!;
    }

    public async Task<Localidade> GetLocalidadeByIdAsync(int localidadeId)
    {
        var localidade = await httpClient.GetAsync($"api/Localidade/Localidade/{localidadeId}");
        var response = await localidade.Content.ReadFromJsonAsync<Localidade>();
        return response!;
    }

    public async Task<Localidade> UpdateLocalidadeAsync(Localidade model)
    {
        var localidade = await httpClient.PutAsJsonAsync("api/Localidade/Update-Localidade", model);
        var response = await localidade.Content.ReadFromJsonAsync<Localidade>();
        return response!;
    }
}
