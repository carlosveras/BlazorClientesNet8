using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClientesNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class DepartamentoController : ControllerBase
{
    private readonly IDepartamentoRepository _departamentoRepository;

    public DepartamentoController(IDepartamentoRepository departamentoRepository)
    {
        _departamentoRepository = departamentoRepository;
    }

    [HttpGet("Departamentos")]
    public async Task<ActionResult<List<Departamento>>> GetAllDepartamentosAsync()
    {
        var departamentos = await _departamentoRepository.GetAllDepartamentosAsync();
        return Ok(departamentos);
    }

    [HttpGet("Departamento/{id}")]
    public async Task<ActionResult<List<Departamento>>> GetSingleDepartamentoAsync(int id)
    {
        var departamento = await _departamentoRepository.GetDepartamentoByIdAsync(id);
        return Ok(departamento);
    }

    [HttpPost("Add-Departamento")]
    public async Task<ActionResult<List<Departamento>>> AddDepartamentoAsync(Departamento model)
    {
        var departamento = await _departamentoRepository.AddDepartamentoAsync(model);
        return Ok(departamento);
    }

    [HttpPut("Update-Departamento")]
    public async Task<ActionResult<List<Departamento>>> UpdateDepartamentoAsync(Departamento model)
    {
        var departamento = await _departamentoRepository.UpdateDepartamentoAsync(model);
        return Ok(departamento);
    }

    [HttpDelete("Delete-Departamento/{id}")]
    public async Task<ActionResult<List<Departamento>>> DeleteDepartamentoAsync(int id)
    {
        var departamento = await _departamentoRepository.DeleteDepartamentoAsync(id);
        return Ok(departamento);
    }
}
