using BlazorClientesNet8.Shared.Entities;

namespace BlazorClientesNet8.Shared.Interfaces;

public interface IDepartamentoRepository
{
    Task<Departamento> AddDepartamentoAsync(Departamento model);
    Task<Departamento> UpdateDepartamentoAsync(Departamento model);
    Task<Departamento> DeleteDepartamentoAsync(int departamentoId);
    Task<List<Departamento>> GetAllDepartamentosAsync();
    Task<Departamento> GetDepartamentoByIdAsync(int departamentoId);
}
