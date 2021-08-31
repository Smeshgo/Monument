using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Appointments_AppointmentIdAppointment",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_CategoryMaterials_CategoryMaterialIdCategoryMaterial",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Photos_CategoryPhotos_CategoryPhotoIdCategoryPhoto",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Photos_CategoryPhotoIdCategoryPhoto",
                table: "Photos");

            migrationBuilder.DropIndex(
                name: "IX_Materials_AppointmentIdAppointment",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_CategoryMaterialIdCategoryMaterial",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "CategoryPhotoIdCategoryPhoto",
                table: "Photos");

            migrationBuilder.DropColumn(
                name: "AppointmentIdAppointment",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "CategoryMaterialIdCategoryMaterial",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "IdAppointment",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "IdCategoryMaterial",
                table: "Materials");

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);

            migrationBuilder.AlterColumn<string>(
                name: "Last_name",
                table: "Customers",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(150)",
                oldMaxLength: 150);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<Guid>(
                name: "CategoryPhotoIdCategoryPhoto",
                table: "Photos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "AppointmentIdAppointment",
                table: "Materials",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "CategoryMaterialIdCategoryMaterial",
                table: "Materials",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "IdAppointment",
                table: "Materials",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AddColumn<Guid>(
                name: "IdCategoryMaterial",
                table: "Materials",
                type: "uniqueidentifier",
                nullable: false,
                defaultValue: new Guid("00000000-0000-0000-0000-000000000000"));

            migrationBuilder.AlterColumn<string>(
                name: "Surname",
                table: "Customers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Last_name",
                table: "Customers",
                type: "nvarchar(150)",
                maxLength: 150,
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Photos_CategoryPhotoIdCategoryPhoto",
                table: "Photos",
                column: "CategoryPhotoIdCategoryPhoto");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_AppointmentIdAppointment",
                table: "Materials",
                column: "AppointmentIdAppointment");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_CategoryMaterialIdCategoryMaterial",
                table: "Materials",
                column: "CategoryMaterialIdCategoryMaterial");

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_Appointments_AppointmentIdAppointment",
                table: "Materials",
                column: "AppointmentIdAppointment",
                principalTable: "Appointments",
                principalColumn: "IdAppointment",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Materials_CategoryMaterials_CategoryMaterialIdCategoryMaterial",
                table: "Materials",
                column: "CategoryMaterialIdCategoryMaterial",
                principalTable: "CategoryMaterials",
                principalColumn: "IdCategoryMaterial",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Photos_CategoryPhotos_CategoryPhotoIdCategoryPhoto",
                table: "Photos",
                column: "CategoryPhotoIdCategoryPhoto",
                principalTable: "CategoryPhotos",
                principalColumn: "IdCategoryPhoto",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
