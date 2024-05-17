using BlazorClientesNet8.Shared.Entities;
using BlazorClientesNet8.Shared.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace BlazorClientesNet8.Controllers;

[Route("api/[controller]")]
[ApiController]
public class CategoriaController : ControllerBase
{
    private readonly ICategoriaRepository _categoriaRepository;

    public CategoriaController(ICategoriaRepository categoriaRepository)
    {
        _categoriaRepository = categoriaRepository;
    }

    [HttpGet("Categorias")]
    public async Task<ActionResult<List<Categoria>>> GetAllCategoriasAsync()
    {
        var categorias = await _categoriaRepository.GetAllCategoriasAsync();
        return Ok(categorias);
    }

    [HttpGet("Cliente/{id}")]
    public async Task<ActionResult<List<Categoria>>> GetSingleCategoriaAsync(int id)
    {
        var categoria = await _categoriaRepository.GetCategoriaByIdAsync(id);
        return Ok(categoria);
    }

    [HttpPost("Add-Categoria")]
    public async Task<ActionResult<List<Categoria>>> AddClienteAsync(Categoria model)
    {
        var categoria = await _categoriaRepository.AddCategoriaAsync(model);
        return Ok(categoria);
    }

    [HttpPut("Update-Categoria")]
    public async Task<ActionResult<List<Categoria>>> UpdateCategoriaAsync(Categoria model)
    {
        var categoria = await _categoriaRepository.UpdateCategoriaAsync(model);
        return Ok(categoria);
    }

    [HttpDelete("Delete-Categoria/{id}")]
    public async Task<ActionResult<List<Categoria>>> DeleteCategoriaAsync(int id)
    {
        var categoria = await _categoriaRepository.DeleteCategoriaAsync(id);
        return Ok(categoria);
    }
}
