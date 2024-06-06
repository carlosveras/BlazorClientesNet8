using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BlazorClientesNet8.Migrations
{
    /// <inheritdoc />
    public partial class novoscampos : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "TotalUsersCltAdmittedOnDay",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalUsersCltFiredOnDay",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalUsersCltToday",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalUsersFiredOnMonth",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalUsersInCompany",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalUsersPjAdmittedOnDay",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalUsersPjFiredOnDay",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "TotalUsersPjToday",
                table: "Categorias",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "TotalUsersCltAdmittedOnDay",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "TotalUsersCltFiredOnDay",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "TotalUsersCltToday",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "TotalUsersFiredOnMonth",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "TotalUsersInCompany",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "TotalUsersPjAdmittedOnDay",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "TotalUsersPjFiredOnDay",
                table: "Categorias");

            migrationBuilder.DropColumn(
                name: "TotalUsersPjToday",
                table: "Categorias");
        }
    }
}
