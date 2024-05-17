using BlazorClientesNet8.Context;
using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorClientesNet8.Repositories;

public class CategoriaRepository : ICategoriaRepository
{
    private readonly ClienteContext _context;
    public CategoriaRepository(ClienteContext context)
    {
        _context = context;
    }

    public async Task<Categoria> AddCategoriaAsync(Categoria model)
    {
        if (model is null) return null!;

        var chk = await _context.Categorias.Where(_ => _.Nome.ToLower()
                                .Equals(model.Nome.ToLower())).FirstOrDefaultAsync();

        if (chk is not null) return null!;

        var novoCategoria = _context.Categorias.Add(model).Entity;
        await _context.SaveChangesAsync();
        return novoCategoria;
    }

    public async Task<Categoria> DeleteCategoriaAsync(int categoriaId)
    {
        var categoria = await _context.Categorias.FirstOrDefaultAsync(_ => _.Id == categoriaId);
        if (categoria is null) return null!;
        _context.Categorias.Remove(categoria);
        await _context.SaveChangesAsync();
        return categoria;
    }

    public async Task<List<Categoria>> GetAllCategoriasAsync() =>
                        await _context.Categorias.ToListAsync();

    public async Task<Categoria> GetCategoriaByIdAsync(int categoriaId)
    {
        var categoria = await _context.Categorias.FirstOrDefaultAsync(_ => _.Id == categoriaId);
        if (categoria is null) return null!;
        return categoria;
    }

    public async Task<Categoria> UpdateCategoriaAsync(Categoria model)
    {
        var categoria = await _context.Categorias.FirstOrDefaultAsync(_ => _.Id == model.Id);
        
        if (categoria is null) return null!;

        categoria.Nome = model.Nome;
        
        await _context.SaveChangesAsync();

        return await _context.Categorias.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
    }
}
