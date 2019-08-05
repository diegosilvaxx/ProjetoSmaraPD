using Microsoft.EntityFrameworkCore.Migrations;

namespace SmaraPD.Migrations
{
    public partial class createFkCliente_2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salaReunioes_clientes_ClienteForeignKey",
                table: "salaReunioes");

            migrationBuilder.RenameColumn(
                name: "ClienteForeignKey",
                table: "salaReunioes",
                newName: "ClienteId");

            migrationBuilder.RenameIndex(
                name: "IX_salaReunioes_ClienteForeignKey",
                table: "salaReunioes",
                newName: "IX_salaReunioes_ClienteId");

            migrationBuilder.AddForeignKey(
                name: "FK_salaReunioes_clientes_ClienteId",
                table: "salaReunioes",
                column: "ClienteId",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_salaReunioes_clientes_ClienteId",
                table: "salaReunioes");

            migrationBuilder.RenameColumn(
                name: "ClienteId",
                table: "salaReunioes",
                newName: "ClienteForeignKey");

            migrationBuilder.RenameIndex(
                name: "IX_salaReunioes_ClienteId",
                table: "salaReunioes",
                newName: "IX_salaReunioes_ClienteForeignKey");

            migrationBuilder.AddForeignKey(
                name: "FK_salaReunioes_clientes_ClienteForeignKey",
                table: "salaReunioes",
                column: "ClienteForeignKey",
                principalTable: "clientes",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
