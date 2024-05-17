using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using System.Net.Http.Json;
using System.Text.Json;

namespace BlazorClientesNet8.Client.Services;
public class CategoriaService : ICategoriaRepository
{
    private readonly HttpClient httpClient;
    private readonly JsonSerializerOptions _options;

    public CategoriaService(HttpClient httpClient)
    {
        this.httpClient = httpClient;
        _options = new JsonSerializerOptions { 
            PropertyNameCaseInsensitive = true 
        };
    }
    public async Task<Categoria> AddCategoriaAsync(Categoria model)
    {
        var cliente = await httpClient.PostAsJsonAsync("api/Categoria/Add-Categoria", model);
        var response = await cliente.Content.ReadFromJsonAsync<Categoria>();
        return response!;
    }

    public async Task<Categoria> DeleteCategoriaAsync(int categoriaId)
    {
        var cliente = await httpClient.DeleteAsync($"api/Categoria/Delete-Categoria/{categoriaId}");
        var response = await cliente.Content.ReadFromJsonAsync<Categoria>();
        return response!;
    }

    public async Task<List<Categoria>> GetAllCategoriasAsync()
    {
        var clientes = await httpClient.GetAsync("api/Categoria/Categorias");
        var response = await clientes.Content.ReadFromJsonAsync<List<Categoria>>();
        return response!;
    }

    public async Task<Categoria> GetCategoriaByIdAsync(int categoriaId)
    {
        var cliente = await httpClient.GetAsync($"api/Categoria/Categoria/{categoriaId}");
        var response = await cliente.Content.ReadFromJsonAsync<Categoria>();
        return response!;
    }

    public async Task<Categoria> UpdateCategoriaAsync(Categoria model)
    {
        var cliente = await httpClient.PutAsJsonAsync("api/Categoria/Update-Categoria", model);
        var response = await cliente.Content.ReadFromJsonAsync<Categoria>();
        return response!;
    }
}
