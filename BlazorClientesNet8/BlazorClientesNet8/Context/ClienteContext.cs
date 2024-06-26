﻿using BlazorClientesNet8.Shared.Entities;
using Microsoft.EntityFrameworkCore;

namespace BlazorClientesNet8.Context;

public class ClienteContext : DbContext
{
    public ClienteContext(DbContextOptions options) : base(options)
    { }

    public DbSet<Cliente> Clientes { get; set; }

    public DbSet<Categoria> Categorias { get; set; }

    public DbSet<Colaborador> Colaboradores { get; set; }
    public DbSet<TipoContratacao> TiposContratacao { get; set; }

    public DbSet<Departamento> Departamentos { get; set; }

    public DbSet<Localidade> Localidades { get; set; }
}
