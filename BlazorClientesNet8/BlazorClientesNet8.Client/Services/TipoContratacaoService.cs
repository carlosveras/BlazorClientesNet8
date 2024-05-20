using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorClientesNet8.Client.Services;
public class TipoContratacaoService : ITipoContratacaoRepository
{
    private readonly HttpClient httpClient;
    private readonly JsonSerializerOptions _options;

    public TipoContratacaoService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        _options = new JsonSerializerOptions { 
            PropertyNameCaseInsensitive = true 
        };
    }
    public async Task<TipoContratacao> AddTipoContratacaoAsync(TipoContratacao model)
    {
        var tipoContratacao = await httpClient.PostAsJsonAsync("api/TipoContratacao/Add-TipoContratacao", model);
        var response = await tipoContratacao.Content.ReadFromJsonAsync<TipoContratacao>();
        return response!;
    }

    public async Task<TipoContratacao> DeleteTipoContratacaoAsync(int tipoContratacaoId)
    {
        var tipoContratacao = await httpClient.DeleteAsync($"api/TipoContratacao/Delete-TipoContratacao/{tipoContratacaoId}");
        var response = await tipoContratacao.Content.ReadFromJsonAsync<TipoContratacao>();
        return response!;
    }

    public async Task<List<TipoContratacao>> GetAllTiposContratacaoAsync()
    {
        var tiposContratacao = await httpClient.GetAsync("api/TipoContratacao/TiposContratacao");
        var response = await tiposContratacao.Content.ReadFromJsonAsync<List<TipoContratacao>>();
        return response!;
    }

    public async Task<TipoContratacao> GetTipoContratacaoByIdAsync(int tipoContratacaoId)
    {
        var tipoContratacao = await httpClient.GetAsync($"api/TipoContratacao/TipoContratacao/{tipoContratacaoId}");
        var response = await tipoContratacao.Content.ReadFromJsonAsync<TipoContratacao>();
        return response!;
    }

    public async Task<TipoContratacao> UpdateTipoContratacaoAsync(TipoContratacao model)
    {
        var tipoContratacao = await httpClient.PutAsJsonAsync("api/TipoContratacao/Update-TipoContratacao", model);
        var response = await tipoContratacao.Content.ReadFromJsonAsync<TipoContratacao>();
        return response!;
    }
}
