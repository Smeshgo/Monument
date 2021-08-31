using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "CategoryMaterials");

            migrationBuilder.DropTable(
                name: "CategoryPhotos");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    IdAppointment = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateAppointment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.IdAppointment);
                });

            migrationBuilder.CreateTable(
                name: "CategoryMaterials",
                columns: table => new
                {
                    IdCategoryMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreateCategoryMaterial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateCategoryMaterial = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryMaterials", x => x.IdCategoryMaterial);
                });

            migrationBuilder.CreateTable(
                name: "CategoryPhotos",
                columns: table => new
                {
                    IdCategoryPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatePhotoPhoto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UpdateCategoryPhoto = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPhotos", x => x.IdCategoryPhoto);
                });
        }
    }
}
