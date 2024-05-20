using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorClientesNet8.Migrations
{
    /// <inheritdoc />
    public partial class ColabAlterado1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Departamento",
                table: "Colaboradores",
                newName: "TipoContratacaoId");

            migrationBuilder.RenameColumn(
                name: "ContratacaoId",
                table: "Colaboradores",
                newName: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_DepartamentoId",
                table: "Colaboradores",
                column: "DepartamentoId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_LocalidadeId",
                table: "Colaboradores",
                column: "LocalidadeId");

            migrationBuilder.CreateIndex(
                name: "IX_Colaboradores_TipoContratacaoId",
                table: "Colaboradores",
                column: "TipoContratacaoId");

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Departamentos_DepartamentoId",
                table: "Colaboradores",
                column: "DepartamentoId",
                principalTable: "Departamentos",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_Localidades_LocalidadeId",
                table: "Colaboradores",
                column: "LocalidadeId",
                principalTable: "Localidades",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Colaboradores_TiposContratacao_TipoContratacaoId",
                table: "Colaboradores",
                column: "TipoContratacaoId",
                principalTable: "TiposContratacao",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Departamentos_DepartamentoId",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_Localidades_LocalidadeId",
                table: "Colaboradores");

            migrationBuilder.DropForeignKey(
                name: "FK_Colaboradores_TiposContratacao_TipoContratacaoId",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_DepartamentoId",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_LocalidadeId",
                table: "Colaboradores");

            migrationBuilder.DropIndex(
                name: "IX_Colaboradores_TipoContratacaoId",
                table: "Colaboradores");

            migrationBuilder.RenameColumn(
                name: "TipoContratacaoId",
                table: "Colaboradores",
                newName: "Departamento");

            migrationBuilder.RenameColumn(
                name: "DepartamentoId",
                table: "Colaboradores",
                newName: "ContratacaoId");
        }
    }
}
