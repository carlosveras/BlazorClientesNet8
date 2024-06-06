using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClientesNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class ColaboradorController : ControllerBase
{
    private readonly IColaboradorRepository _colaboradorRepository;

    public ColaboradorController(IColaboradorRepository colaboradorRepository)
    {
        _colaboradorRepository = colaboradorRepository;
    }

    [HttpGet("Colaboradores")]
    public async Task<ActionResult<List<Colaborador>>> GetAllColaboradoresAsync()
    {
        var colaboradores = await _colaboradorRepository.GetAllColaboradoresAsync();
        return Ok(colaboradores);
    }

    [HttpGet("ColaboradoresDemitidosHoje")]
    public async Task<ActionResult<List<Colaborador>>> GetAllColaboradoresCltFiredTodayAsync()
    {
        var colaboradores = await _colaboradorRepository.GetAllColaboradoresCltFiredTodayAsync();
        return Ok(colaboradores);
    }

    [HttpGet("ColaboradoresAdmitidosHoje")]
    public async Task<ActionResult<List<Colaborador>>> GetAllColaboradoresCltAdmittedTodayAsync()
    {
        var colaboradores = await _colaboradorRepository.GetAllColaboradoresCltAdmittedTodayAsync();
        return Ok(colaboradores);
    }

    [HttpGet("Colaborador/{id}")]
    public async Task<ActionResult<List<Colaborador>>> GetSingleColaboradorAsync(int id)
    {
        var colaborador = await _colaboradorRepository.GetColaboradorByIdAsync(id);
        return Ok(colaborador);
    }

    [HttpPost("Add-Colaborador")]
    public async Task<ActionResult<List<Colaborador>>> AddColaboradorAsync(Colaborador model)
    {
        var colaborador = await _colaboradorRepository.AddColaboradorAsync(model);
        return Ok(colaborador);
    }

    [HttpPut("Update-Colaborador")]
    public async Task<ActionResult<List<Colaborador>>> UpdateColaboradorAsync(Colaborador model)
    {
        var colaborador = await _colaboradorRepository.UpdateColaboradorAsync(model);
        return Ok(colaborador);
    }

    [HttpDelete("Delete-Colaborador/{id}")]
    public async Task<ActionResult<List<Colaborador>>> DeleteColaboradorAsync(int id)
    {
        var colaborador = await _colaboradorRepository.DeleteColaboradorAsync(id);
        return Ok(colaborador);
    }
}
