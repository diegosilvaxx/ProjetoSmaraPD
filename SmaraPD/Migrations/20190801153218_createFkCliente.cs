using Microsoft.EntityFrameworkCore.Migrations;

namespace SmaraPD.Migrations
{
    public partial class createFkCliente : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_clientes_salaReunioes_ClienteId",
                table: "clientes");

            migrationBuilder.DropIndex(
                name: "IX_clientes_ClienteId",
                table: "clientes");

            migrationBuilder.DropColumn(
                name: "ClienteId",
                table: "clientes");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "salaReunioes",
                newName: "ClienteForeignKey");

            migrationBuilder.CreateIndex(
                name: "IX_salaReunioes_ClienteForeignKey",
                table: "salaReunioes",
                column: "ClienteForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_salaReunioes_clientes_ClienteForeignKey",
                table: "salaReunioes",
                column: "ClienteForeignKey",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salaReunioes_clientes_ClienteForeignKey",
                table: "salaReunioes");

            migrationBuilder.DropIndex(
                name: "IX_salaReunioes_ClienteForeignKey",
                table: "salaReunioes");

            migrationBuilder.RenameColumn(
                name: "ClienteForeignKey",
                table: "salaReunioes",
                newName: "ClienteId");

            migrationBuilder.AddColumn<int>(
                name: "ClienteId",
                table: "clientes",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_clientes_ClienteId",
                table: "clientes",
                column: "ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_clientes_salaReunioes_ClienteId",
                table: "clientes",
                column: "ClienteId",
                principalTable: "salaReunioes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
