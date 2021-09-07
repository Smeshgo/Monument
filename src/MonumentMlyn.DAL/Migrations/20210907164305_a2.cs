using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations",
                columns: new[] { "IdWorker", "Date" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations",
                column: "IdWorker");
        }
    }
}
