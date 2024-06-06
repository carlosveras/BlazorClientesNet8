﻿// <auto-generated />
using System;
using BlazorClientesNet8.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorClientesNet8.Migrations
{
    [DbContext(typeof(ClienteContext))]
    [Migration("20240605105145_novos campos")]
    partial class novoscampos
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0-rc.2.23480.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("BlazorClientesNet8.Shared.Entities.Categoria", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("IconCSS")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<string>("PaginaDetalhes")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.Property<int>("TotalDaCategoria")
                        .HasColumnType("int");

                    b.Property<int>("TotalUsersCltAdmittedOnDay")
                        .HasColumnType("int");

                    b.Property<int>("TotalUsersCltFiredOnDay")
                        .HasColumnType("int");

                    b.Property<int>("TotalUsersCltToday")
                        .HasColumnType("int");

                    b.Property<int>("TotalUsersFiredOnMonth")
                        .HasColumnType("int");

                    b.Property<int>("TotalUsersInCompany")
                        .HasColumnType("int");

                    b.Property<int>("TotalUsersPjAdmittedOnDay")
                        .HasColumnType("int");

                    b.Property<int>("TotalUsersPjFiredOnDay")
                        .HasColumnType("int");

                    b.Property<int>("TotalUsersPjToday")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Categorias");
                });

            modelBuilder.Entity("BlazorClientesNet8.Shared.Entities.Cliente", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Idade")
                        .HasColumnType("int");

                    b.Property<string>("Nome")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Clientes");
                });

            modelBuilder.Entity("BlazorClientesNet8.Shared.Entities.Colaborador", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("AcessoEmail")
                        .HasColumnType("bit");

                    b.Property<string>("Area")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Cargo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CentroDeCusto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("CentroDeResultado")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("DataAdmissao")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataFinal")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataNascimento")
                        .HasColumnType("datetime2");

                    b.Property<int>("DepartamentoId")
                        .HasColumnType("int");

                    b.Property<string>("EmailPessoal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("FuncionarioEstrangeiro")
                        .HasColumnType("bit");

                    b.Property<int>("LocalidadeId")
                        .HasColumnType("int");

                    b.Property<string>("NomeCompleto")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NumeroIdentificacaoFiscal")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("TipoContratacaoId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("DepartamentoId");

                    b.HasIndex("LocalidadeId");

                    b.HasIndex("TipoContratacaoId");

                    b.ToTable("Colaboradores");
                });

            modelBuilder.Entity("BlazorClientesNet8.Shared.Entities.Departamento", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("NomeDepartamento")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Departamentos");
                });

            modelBuilder.Entity("BlazorClientesNet8.Shared.Entities.Localidade", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("bit");

                    b.Property<string>("NomeLocalidade")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Localidades");
                });

            modelBuilder.Entity("BlazorClientesNet8.Shared.Entities.TipoContratacao", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Descricao")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsAtivo")
                        .HasColumnType("bit");

                    b.HasKey("Id");

                    b.ToTable("TiposContratacao");
                });

            modelBuilder.Entity("BlazorClientesNet8.Shared.Entities.Colaborador", b =>
                {
                    b.HasOne("BlazorClientesNet8.Shared.Entities.Departamento", "Departamento")
                        .WithMany()
                        .HasForeignKey("DepartamentoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorClientesNet8.Shared.Entities.Localidade", "Localidade")
                        .WithMany()
                        .HasForeignKey("LocalidadeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("BlazorClientesNet8.Shared.Entities.TipoContratacao", "TipoContratacao")
                        .WithMany()
                        .HasForeignKey("TipoContratacaoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Departamento");

                    b.Navigation("Localidade");

                    b.Navigation("TipoContratacao");
                });
#pragma warning restore 612, 618
        }
    }
}
