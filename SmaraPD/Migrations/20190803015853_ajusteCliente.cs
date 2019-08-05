using Microsoft.EntityFrameworkCore.Migrations;

namespace SmaraPD.Migrations
{
    public partial class ajusteCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Login",
                table: "clientes",
                newName: "Email");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Email",
                table: "clientes",
                newName: "Login");
        }
    }
}
