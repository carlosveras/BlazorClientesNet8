using BlazorClientesNet8.Shared.Entities;

namespace BlazorClientesNet8.Shared.Interfaces;

public interface IColaboradorRepository
{
    Task<Colaborador> AddColaboradorAsync(Colaborador model);
    Task<Colaborador> UpdateColaboradorAsync(Colaborador model);
    Task<Colaborador> DeleteColaboradorAsync(int colaboradorId);
    Task<List<Colaborador>> GetAllColaboradoresAsync();
    Task<Colaborador> GetColaboradorByIdAsync(int colaboradorId);
}
