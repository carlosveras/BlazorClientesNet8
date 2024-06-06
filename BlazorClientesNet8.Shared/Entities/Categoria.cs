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

    public int TotalUsersCltToday { get; init; }

    public int TotalUsersCltAdmittedOnDay { get; init; }

    public int TotalUsersCltFiredOnDay { get; init; }

    public int TotalUsersPjToday { get; init; }

    public int TotalUsersPjAdmittedOnDay { get; init; }

    public int TotalUsersPjFiredOnDay { get; init; }

    public int TotalUsersFiredOnMonth { get; init; }

    public int TotalUsersInCompany { get; init; }
}
