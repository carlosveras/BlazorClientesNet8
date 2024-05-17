using System.ComponentModel.DataAnnotations;

namespace BlazorClientesNet8.Shared.Entities;

public class Categoria
{
    public int Id { get; set; }

    [MaxLength(100)]
    public string Nome { get; set; } = string.Empty;
    public string IconCSS { get; set; } = string.Empty;

    public int TotalDaCategoria { get; set; }

    [MaxLength(100)]
    public string PaginaDetalhes {  get; set; } = string.Empty;

    public bool Status {  get; set; }
}
