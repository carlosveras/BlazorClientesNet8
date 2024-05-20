using BlazorClientesNet8.Context;
using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorClientesNet8.Repositories;

public class DepartamentoRepository : IDepartamentoRepository
{
    private readonly ClienteContext _context;
    public DepartamentoRepository(ClienteContext context)
    {
        _context = context;
    }

    public async Task<Departamento> AddDepartamentoAsync(Departamento model)
    {
        if (model is null) return null!;

        var chk = await _context.Departamentos.Where(_ => _.NomeDepartamento.ToLower()
                                .Equals(model.NomeDepartamento.ToLower())).FirstOrDefaultAsync();

        if (chk is not null) return null!;

        var novoDepartamento = _context.Departamentos.Add(model).Entity;
        await _context.SaveChangesAsync();
        return novoDepartamento;
    }

    public async Task<Departamento> DeleteDepartamentoAsync(int departamentoId)
    {
        var departamento = await _context.Departamentos.FirstOrDefaultAsync(_ => _.Id == departamentoId);
        if (departamento is null) return null!;
        _context.Departamentos.Remove(departamento);
        await _context.SaveChangesAsync();
        return departamento;
    }

    public async Task<List<Departamento>> GetAllDepartamentosAsync() =>
                        await _context.Departamentos.ToListAsync();

    public async Task<Departamento> GetDepartamentoByIdAsync(int departamentoId)
    {
        var departamento = await _context.Departamentos.FirstOrDefaultAsync(_ => _.Id == departamentoId);
        if (departamento is null) return null!;
        return departamento;
    }

    public async Task<Departamento> UpdateDepartamentoAsync(Departamento model)
    {
        var departamento = await _context.Departamentos.FirstOrDefaultAsync(_ => _.Id == model.Id);
        
        if (departamento is null) return null!;

        departamento.NomeDepartamento = model.NomeDepartamento;
        
        await _context.SaveChangesAsync();

        return await _context.Departamentos.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
    }
}
