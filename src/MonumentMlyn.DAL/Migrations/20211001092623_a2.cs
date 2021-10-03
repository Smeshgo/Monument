using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monuments_Photos_PhotoId",
                table: "Monuments");

            migrationBuilder.AlterColumn<Guid>(
                name: "PhotoId",
                table: "Monuments",
                type: "uniqueidentifier",
                nullable: true,
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier");

            migrationBuilder.AddForeignKey(
                name: "FK_Monuments_Photos_PhotoId",
                table: "Monuments",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Monuments_Photos_PhotoId",
                table: "Monuments");

            migrationBuilder.AlterColumn<Guid>(
                name: "PhotoId",
                table: "Monuments",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"),
                oldClrType: typeof(Guid),
                oldType: "uniqueidentifier",
                oldNullable: true);

            migrationBuilder.AddForeignKey(
                name: "FK_Monuments_Photos_PhotoId",
                table: "Monuments",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
