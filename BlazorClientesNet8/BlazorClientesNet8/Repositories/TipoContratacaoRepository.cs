using BlazorClientesNet8.Context;
using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorClientesNet8.Repositories;

public class TipoContratacaoRepository : ITipoContratacaoRepository
{
    private readonly ClienteContext _context;
    public TipoContratacaoRepository(ClienteContext context)
    {
        _context = context;
    }

    public async Task<TipoContratacao> AddTipoContratacaoAsync(TipoContratacao model)
    {
        if (model is null) return null!;

        var chk = await _context.TiposContratacao.Where(_ => _.Descricao.ToLower()
                                .Equals(model.Descricao.ToLower())).FirstOrDefaultAsync();

        if (chk is not null) return null!;

        var novoTipoContratacao = _context.TiposContratacao.Add(model).Entity;
        await _context.SaveChangesAsync();
        return novoTipoContratacao;
    }

    public async Task<TipoContratacao> DeleteTipoContratacaoAsync(int tipoContratacaoId)
    {
        var tipoContratacao = await _context.TiposContratacao.FirstOrDefaultAsync(_ => _.Id == tipoContratacaoId);
        if (tipoContratacao is null) return null!;
        _context.TiposContratacao.Remove(tipoContratacao);
        await _context.SaveChangesAsync();
        return tipoContratacao;
    }

    public async Task<List<TipoContratacao>> GetAllTiposContratacaoAsync() =>
                        await _context.TiposContratacao.ToListAsync();

    public async Task<TipoContratacao> GetTipoContratacaoByIdAsync(int tipoContratacaoId)
    {
        var tipoContratacao = await _context.TiposContratacao.FirstOrDefaultAsync(_ => _.Id == tipoContratacaoId);
        if (tipoContratacao is null) return null!;
        return tipoContratacao;
    }

    public async Task<TipoContratacao> UpdateTipoContratacaoAsync(TipoContratacao model)
    {
        var tipoContratacao = await _context.TiposContratacao.FirstOrDefaultAsync(_ => _.Id == model.Id);
        
        if (tipoContratacao is null) return null!;

        tipoContratacao.Descricao = model.Descricao;
        
        await _context.SaveChangesAsync();

        return await _context.TiposContratacao.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
    }
}
