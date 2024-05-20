using BlazorClientesNet8.Shared.Entities;

namespace BlazorClientesNet8.Shared.Interfaces;

public interface ILocalidadeRepository
{
    Task<Localidade> AddLocalidadeAsync(Localidade model);
    Task<Localidade> UpdateLocalidadeAsync(Localidade model);
    Task<Localidade> DeleteLocalidadeAsync(int localidadeId);
    Task<List<Localidade>> GetAllLocalidadesAsync();
    Task<Localidade> GetLocalidadeByIdAsync(int localidadeId);
}
