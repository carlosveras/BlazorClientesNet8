﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorClientesNet8.Migrations
{
    /// <inheritdoc />
    public partial class ColaboradorETipo : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Colaboradores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NomeCompleto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FuncionarioEstrangeiro = table.Column<bool>(type: "bit", nullable: false),
                    NumeroIdentificacaoFiscal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EmailPessoal = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DataNascimento = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataAdmissao = table.Column<DateTime>(type: "datetime2", nullable: false),
                    DataFinal = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Departamento = table.Column<int>(type: "int", nullable: false),
                    LocalidadeId = table.Column<int>(type: "int", nullable: false),
                    AcessoEmail = table.Column<bool>(type: "bit", nullable: false),
                    Area = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Cargo = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CentroDeCusto = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CentroDeResultado = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ContratacaoId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Colaboradores", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Colaboradores");
        }
    }
}
