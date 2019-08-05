using Microsoft.EntityFrameworkCore.Migrations;

namespace SmaraPD.Migrations
{
    public partial class ajusteBanco : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Roles",
                table: "salaReunioes");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Roles",
                table: "salaReunioes",
                nullable: true);
        }
    }
}
