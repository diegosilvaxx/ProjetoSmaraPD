using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SmaraPD.Migrations
{
    public partial class UpdateData : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "DataLocacao",
                table: "salaReunioes",
                nullable: true,
                oldClrType: typeof(DateTime));

            migrationBuilder.AlterColumn<string>(
                name: "DataEntrega",
                table: "salaReunioes",
                nullable: true,
                oldClrType: typeof(DateTime));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "DataLocacao",
                table: "salaReunioes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);

            migrationBuilder.AlterColumn<DateTime>(
                name: "DataEntrega",
                table: "salaReunioes",
                nullable: false,
                oldClrType: typeof(string),
                oldNullable: true);
        }
    }
}
