using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a9 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Materials_MaterialId1",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Monuments_MonumentId",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_MaterialId1",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_MonumentId",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "MaterialId1",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "MonumentId",
                table: "Materials");

            migrationBuilder.CreateTable(
                name: "MaterialMonument",
                columns: table => new
                {
                    MaterialsMaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonumentsMonumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialMonument", x => new { x.MaterialsMaterialId, x.MonumentsMonumentId });
                    table.ForeignKey(
                        name: "FK_MaterialMonument_Materials_MaterialsMaterialId",
                        column: x => x.MaterialsMaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialMonument_Monuments_MonumentsMonumentId",
                        column: x => x.MonumentsMonumentId,
                        principalTable: "Monuments",
                        principalColumn: "MonumentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonument_MonumentsMonumentId",
                table: "MaterialMonument",
                column: "MonumentsMonumentId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "MaterialMonument");

            migrationBuilder.AddColumn<Guid>(
                name: "MaterialId1",
                table: "Materials",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MonumentId",
                table: "Materials",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialId1",
                table: "Materials",
                column: "MaterialId1");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MonumentId",
                table: "Materials",
                column: "MonumentId");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Materials_MaterialId1",
                table: "Materials",
                column: "MaterialId1",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Monuments_MonumentId",
                table: "Materials",
                column: "MonumentId",
                principalTable: "Monuments",
                principalColumn: "MonumentId",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
