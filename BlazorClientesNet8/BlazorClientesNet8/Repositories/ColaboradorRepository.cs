using BlazorClientesNet8.Client.Pages;
using BlazorClientesNet8.Context;
using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace BlazorClientesNet8.Repositories;

public class ColaboradorRepository : IColaboradorRepository
{
    private readonly ClienteContext _context;
    public ColaboradorRepository(ClienteContext context)
    {
        _context = context;
    }


    public async Task<List<Colaborador>> GetAllColaboradoresAsync()
    {
        var colaboradores = await _context.Colaboradores.Include(d => d.Departamento).ToListAsync();
        if (colaboradores is null) return null!;
        return colaboradores;
    }


    public async Task<List<Colaborador>> GetAllColaboradoresCltFiredTodayAsync()
    {
        var colaboradores = await _context.Colaboradores
                                          .Where(d => d.DataFinal.Date == DateTime.Now.Date)
                                          .Where(c => c.TipoContratacaoId == 1)
                                          .Include(d => d.Departamento).ToListAsync();

        if (colaboradores is null) return null!;
        return colaboradores;
    }

    public async Task<List<Colaborador>> GetAllColaboradoresFiredOnMonthAsync()
    {


        var colaboradores = await _context.Colaboradores
                                          .Where(d => d.DataFinal.Month == DateTime.Now.Month)
                                          .Include(d => d.Departamento).ToListAsync();

        if (colaboradores is null) return null!;
        return colaboradores;
    }










    public async Task<List<Colaborador>> GetAllColaboradoresCltAdmittedTodayAsync()
    {
        var colaboradores = await _context.Colaboradores
                                          .Where(d => d.DataAdmissao.Date == DateTime.Now.Date)
                                          .Where(c => c.TipoContratacaoId == 1)
                                          .Include(d => d.Departamento).ToListAsync();

        if (colaboradores is null) return null!;
        return colaboradores;
    }



    public async Task<Colaborador> GetColaboradorByIdAsync(int clienteId)
    {
        var cliente = await _context.Colaboradores.FirstOrDefaultAsync(_ => _.Id == clienteId);
        if (cliente is null) return null!;
        return cliente;
    }





    public async Task<Colaborador> AddColaboradorAsync(Colaborador model)
    {
        if (model is null) return null!;

        var chk = await _context.Colaboradores.Where(_ => _.NomeCompleto.ToLower()
                                .Equals(model.NomeCompleto.ToLower())).FirstOrDefaultAsync();

        if (chk is not null) return null!;

        var novoCliente = _context.Colaboradores.Add(model).Entity;
        await _context.SaveChangesAsync();
        return novoCliente;
    }

    public async Task<Colaborador> DeleteColaboradorAsync(int colaboradorId)
    {
        var cliente = await _context.Colaboradores.FirstOrDefaultAsync(_ => _.Id == colaboradorId);
        if (cliente is null) return null!;
        _context.Colaboradores.Remove(cliente);
        await _context.SaveChangesAsync();
        return cliente;
    }

    public async Task<Colaborador> UpdateColaboradorAsync(Colaborador model)
    {
        var cliente = await _context.Colaboradores.FirstOrDefaultAsync(_ => _.Id == model.Id);

        if (cliente is null) return null!;

        cliente.NomeCompleto = model.NomeCompleto;
        cliente.EmailPessoal = model.EmailPessoal;

        await _context.SaveChangesAsync();

        return await _context.Colaboradores.FirstOrDefaultAsync(_ => _.Id == model.Id)!;
    }
}
