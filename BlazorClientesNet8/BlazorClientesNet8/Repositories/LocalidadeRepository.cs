using BlazorClientesNet8.Context;
using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorClientesNet8.Repositories;

public class LocalidadeRepository : ILocalidadeRepository
{
    private readonly ClienteContext _context;
    public LocalidadeRepository(ClienteContext context)
    {
        _context = context;
    }

    public async Task<Localidade> AddLocalidadeAsync(Localidade model)
    {
        if (model is null) return null!;

        var chk = await _context.Localidades.Where(_ => _.NomeLocalidade.ToLower()
                                .Equals(model.NomeLocalidade.ToLower())).FirstOrDefaultAsync();

        if (chk is not null) return null!;

        var novaLocalidade = _context.Localidades.Add(model).Entity;
        await _context.SaveChangesAsync();
        return novaLocalidade;
    }

    public async Task<Localidade> DeleteLocalidadeAsync(int localidadeId)
    {
        var localidade = await _context.Localidades.FirstOrDefaultAsync(_ => _.Id == localidadeId);
        if (localidade is null) return null!;
        _context.Localidades.Remove(localidade);
        await _context.SaveChangesAsync();
        return localidade;
    }

    public async Task<List<Localidade>> GetAllLocalidadesAsync() =>
                        await _context.Localidades.ToListAsync();

    public async Task<Localidade> GetLocalidadeByIdAsync(int localidadeId)
    {
        var localidade = await _context.Localidades.FirstOrDefaultAsync(_ => _.Id == localidadeId);
        if (localidade is null) return null!;
        return localidade;
    }

    public async Task<Localidade> UpdateLocalidadeAsync(Localidade model)
    {
        var localidade = await _context.Localidades.FirstOrDefaultAsync(_ => _.Id == model.Id);
        
        if (localidade is null) return null!;

        localidade.NomeLocalidade = model.NomeLocalidade;
        
        await _context.SaveChangesAsync();

        return await _context.Localidades.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
    }
}
