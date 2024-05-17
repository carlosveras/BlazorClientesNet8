using BlazorClientesNet8.Shared.Entities;

namespace BlazorClientesNet8.Shared.Interfaces;

public interface ICategoriaRepository
{
    Task<Categoria> AddCategoriaAsync(Categoria model);
    Task<Categoria> UpdateCategoriaAsync(Categoria model);
    Task<Categoria> DeleteCategoriaAsync(int categoriaId);
    Task<List<Categoria>> GetAllCategoriasAsync();
    Task<Categoria> GetCategoriaByIdAsync(int categoriaId);
}
