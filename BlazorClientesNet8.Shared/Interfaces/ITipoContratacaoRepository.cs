using BlazorClientesNet8.Shared.Entities;

namespace BlazorClientesNet8.Shared.Interfaces;

public interface ITipoContratacaoRepository
{
    Task<TipoContratacao> AddTipoContratacaoAsync(TipoContratacao model);
    Task<TipoContratacao> UpdateTipoContratacaoAsync(TipoContratacao model);
    Task<TipoContratacao> DeleteTipoContratacaoAsync(int tipoContratacaoId);
    Task<List<TipoContratacao>> GetAllTiposContratacaoAsync();
    Task<TipoContratacao> GetTipoContratacaoByIdAsync(int tipoContratacaoId);
}
