using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticlePhotos_Articles_ArticlearticleId",
                table: "ArticlePhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticlePhotos_Photos_PhotoPhotoId",
                table: "ArticlePhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleUsers_Articles_ArticlearticleId",
                table: "ArticleUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleUsers_Users_UserIdUser",
                table: "ArticleUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Calculations_Workers_WorkerIdWorker",
                table: "Calculations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialMonuments_Materials_MaterialIdMaterial",
                table: "MaterialMonuments");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialMonuments_Monuments_MonumentIdMonument",
                table: "MaterialMonuments");

            migrationBuilder.DropForeignKey(
                name: "FK_Monuments_Customers_Customerid_customer",
                table: "Monuments");

            migrationBuilder.DropForeignKey(
                name: "FK_Monuments_Photos_PhotoPhotoId",
                table: "Monuments");

            migrationBuilder.DropForeignKey(
                name: "FK_MonumentWorkers_Monuments_MonumentIdMonument",
                table: "MonumentWorkers");

            migrationBuilder.DropForeignKey(
                name: "FK_MonumentWorkers_Workers_WorkerIdWorker",
                table: "MonumentWorkers");

            migrationBuilder.DropIndex(
                name: "IX_MonumentWorkers_MonumentIdMonument",
                table: "MonumentWorkers");

            migrationBuilder.DropIndex(
                name: "IX_MonumentWorkers_WorkerIdWorker",
                table: "MonumentWorkers");

            migrationBuilder.DropIndex(
                name: "IX_Monuments_Customerid_customer",
                table: "Monuments");

            migrationBuilder.DropIndex(
                name: "IX_Monuments_PhotoPhotoId",
                table: "Monuments");

            migrationBuilder.DropIndex(
                name: "IX_MaterialMonuments_MaterialIdMaterial",
                table: "MaterialMonuments");

            migrationBuilder.DropIndex(
                name: "IX_MaterialMonuments_MonumentIdMonument",
                table: "MaterialMonuments");

            migrationBuilder.DropIndex(
                name: "IX_Calculations_WorkerIdWorker",
                table: "Calculations");

            migrationBuilder.DropIndex(
                name: "IX_ArticleUsers_ArticlearticleId",
                table: "ArticleUsers");

            migrationBuilder.DropIndex(
                name: "IX_ArticleUsers_UserIdUser",
                table: "ArticleUsers");

            migrationBuilder.DropIndex(
                name: "IX_ArticlePhotos_ArticlearticleId",
                table: "ArticlePhotos");

            migrationBuilder.DropIndex(
                name: "IX_ArticlePhotos_PhotoPhotoId",
                table: "ArticlePhotos");

            migrationBuilder.DropColumn(
                name: "MonumentIdMonument",
                table: "MonumentWorkers");

            migrationBuilder.DropColumn(
                name: "WorkerIdWorker",
                table: "MonumentWorkers");

            migrationBuilder.DropColumn(
                name: "Customerid_customer",
                table: "Monuments");

            migrationBuilder.DropColumn(
                name: "PhotoPhotoId",
                table: "Monuments");

            migrationBuilder.DropColumn(
                name: "MaterialIdMaterial",
                table: "MaterialMonuments");

            migrationBuilder.DropColumn(
                name: "MonumentIdMonument",
                table: "MaterialMonuments");

            migrationBuilder.DropColumn(
                name: "WorkerIdWorker",
                table: "Calculations");

            migrationBuilder.DropColumn(
                name: "ArticlearticleId",
                table: "ArticleUsers");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "ArticleUsers");

            migrationBuilder.DropColumn(
                name: "ArticlearticleId",
                table: "ArticlePhotos");

            migrationBuilder.DropColumn(
                name: "PhotoPhotoId",
                table: "ArticlePhotos");

            migrationBuilder.RenameColumn(
                name: "IdWorker",
                table: "Workers",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "Users",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "IdRole",
                table: "Roles",
                newName: "RoleId");

            migrationBuilder.RenameColumn(
                name: "PhotoId",
                table: "Photos",
                newName: "PhotoId");

            migrationBuilder.RenameColumn(
                name: "IdWorker",
                table: "MonumentWorkers",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "IdMonument",
                table: "MonumentWorkers",
                newName: "MonumentId");

            migrationBuilder.RenameColumn(
                name: "Id_customer",
                table: "Monuments",
                newName: "PhotoId");

            migrationBuilder.RenameColumn(
                name: "PhotoId",
                table: "Monuments",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "IdMonument",
                table: "Monuments",
                newName: "MonumentId");

            migrationBuilder.RenameColumn(
                name: "IdMaterial",
                table: "Materials",
                newName: "MaterialId");

            migrationBuilder.RenameColumn(
                name: "IdMonument",
                table: "MaterialMonuments",
                newName: "MonumentId");

            migrationBuilder.RenameColumn(
                name: "IdMaterial",
                table: "MaterialMonuments",
                newName: "MaterialId");

            migrationBuilder.RenameColumn(
                name: "update_user",
                table: "Customers",
                newName: "UpdateUser");

            migrationBuilder.RenameColumn(
                name: "create_user",
                table: "Customers",
                newName: "CreateUser");

            migrationBuilder.RenameColumn(
                name: "Last_name",
                table: "Customers",
                newName: "LastName");

            migrationBuilder.RenameColumn(
                name: "id_customer",
                table: "Customers",
                newName: "CustomerId");

            migrationBuilder.RenameColumn(
                name: "IdWorker",
                table: "Calculations",
                newName: "WorkerId");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "ArticleUsers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "articleId",
                table: "ArticleUsers",
                newName: "ArticleId");

            migrationBuilder.RenameColumn(
                name: "articleId",
                table: "Articles",
                newName: "ArticleId");

            migrationBuilder.RenameColumn(
                name: "PhotoId",
                table: "ArticlePhotos",
                newName: "PhotoId");

            migrationBuilder.RenameColumn(
                name: "articleId",
                table: "ArticlePhotos",
                newName: "ArticleId");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorkers_WorkerId",
                table: "MonumentWorkers",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_CustomerId",
                table: "Monuments",
                column: "CustomerId");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_PhotoId",
                table: "Monuments",
                column: "PhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonuments_MonumentId",
                table: "MaterialMonuments",
                column: "MonumentId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUsers_UserId",
                table: "ArticleUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePhotos_PhotoId",
                table: "ArticlePhotos",
                column: "PhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlePhotos_Articles_ArticleId",
                table: "ArticlePhotos",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlePhotos_Photos_PhotoId",
                table: "ArticlePhotos",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleUsers_Articles_ArticleId",
                table: "ArticleUsers",
                column: "ArticleId",
                principalTable: "Articles",
                principalColumn: "ArticleId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleUsers_Users_UserId",
                table: "ArticleUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "UserId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Calculations_Workers_WorkerId",
                table: "Calculations",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialMonuments_Materials_MaterialId",
                table: "MaterialMonuments",
                column: "MaterialId",
                principalTable: "Materials",
                principalColumn: "MaterialId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialMonuments_Monuments_MonumentId",
                table: "MaterialMonuments",
                column: "MonumentId",
                principalTable: "Monuments",
                principalColumn: "MonumentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monuments_Customers_CustomerId",
                table: "Monuments",
                column: "CustomerId",
                principalTable: "Customers",
                principalColumn: "CustomerId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Monuments_Photos_PhotoId",
                table: "Monuments",
                column: "PhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonumentWorkers_Monuments_MonumentId",
                table: "MonumentWorkers",
                column: "MonumentId",
                principalTable: "Monuments",
                principalColumn: "MonumentId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_MonumentWorkers_Workers_WorkerId",
                table: "MonumentWorkers",
                column: "WorkerId",
                principalTable: "Workers",
                principalColumn: "WorkerId",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_ArticlePhotos_Articles_ArticleId",
                table: "ArticlePhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticlePhotos_Photos_PhotoId",
                table: "ArticlePhotos");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleUsers_Articles_ArticleId",
                table: "ArticleUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_ArticleUsers_Users_UserId",
                table: "ArticleUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_Calculations_Workers_WorkerId",
                table: "Calculations");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialMonuments_Materials_MaterialId",
                table: "MaterialMonuments");

            migrationBuilder.DropForeignKey(
                name: "FK_MaterialMonuments_Monuments_MonumentId",
                table: "MaterialMonuments");

            migrationBuilder.DropForeignKey(
                name: "FK_Monuments_Customers_CustomerId",
                table: "Monuments");

            migrationBuilder.DropForeignKey(
                name: "FK_Monuments_Photos_PhotoId",
                table: "Monuments");

            migrationBuilder.DropForeignKey(
                name: "FK_MonumentWorkers_Monuments_MonumentId",
                table: "MonumentWorkers");

            migrationBuilder.DropForeignKey(
                name: "FK_MonumentWorkers_Workers_WorkerId",
                table: "MonumentWorkers");

            migrationBuilder.DropIndex(
                name: "IX_MonumentWorkers_WorkerId",
                table: "MonumentWorkers");

            migrationBuilder.DropIndex(
                name: "IX_Monuments_CustomerId",
                table: "Monuments");

            migrationBuilder.DropIndex(
                name: "IX_Monuments_PhotoId",
                table: "Monuments");

            migrationBuilder.DropIndex(
                name: "IX_MaterialMonuments_MonumentId",
                table: "MaterialMonuments");

            migrationBuilder.DropIndex(
                name: "IX_ArticleUsers_UserId",
                table: "ArticleUsers");

            migrationBuilder.DropIndex(
                name: "IX_ArticlePhotos_PhotoId",
                table: "ArticlePhotos");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Workers",
                newName: "IdWorker");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "Users",
                newName: "IdUser");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "Roles",
                newName: "IdRole");

            migrationBuilder.RenameColumn(
                name: "PhotoId",
                table: "Photos",
                newName: "PhotoId");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "MonumentWorkers",
                newName: "IdWorker");

            migrationBuilder.RenameColumn(
                name: "MonumentId",
                table: "MonumentWorkers",
                newName: "IdMonument");

            migrationBuilder.RenameColumn(
                name: "PhotoId",
                table: "Monuments",
                newName: "Id_customer");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Monuments",
                newName: "PhotoId");

            migrationBuilder.RenameColumn(
                name: "MonumentId",
                table: "Monuments",
                newName: "IdMonument");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "Materials",
                newName: "IdMaterial");

            migrationBuilder.RenameColumn(
                name: "MonumentId",
                table: "MaterialMonuments",
                newName: "IdMonument");

            migrationBuilder.RenameColumn(
                name: "MaterialId",
                table: "MaterialMonuments",
                newName: "IdMaterial");

            migrationBuilder.RenameColumn(
                name: "UpdateUser",
                table: "Customers",
                newName: "update_user");

            migrationBuilder.RenameColumn(
                name: "LastName",
                table: "Customers",
                newName: "Last_name");

            migrationBuilder.RenameColumn(
                name: "CreateUser",
                table: "Customers",
                newName: "create_user");

            migrationBuilder.RenameColumn(
                name: "CustomerId",
                table: "Customers",
                newName: "id_customer");

            migrationBuilder.RenameColumn(
                name: "WorkerId",
                table: "Calculations",
                newName: "IdWorker");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "ArticleUsers",
                newName: "IdUser");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "ArticleUsers",
                newName: "articleId");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "Articles",
                newName: "articleId");

            migrationBuilder.RenameColumn(
                name: "PhotoId",
                table: "ArticlePhotos",
                newName: "PhotoId");

            migrationBuilder.RenameColumn(
                name: "ArticleId",
                table: "ArticlePhotos",
                newName: "articleId");

            migrationBuilder.AddColumn<Guid>(
                name: "MonumentIdMonument",
                table: "MonumentWorkers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkerIdWorker",
                table: "MonumentWorkers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "Customerid_customer",
                table: "Monuments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PhotoPhotoId",
                table: "Monuments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MaterialIdMaterial",
                table: "MaterialMonuments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "MonumentIdMonument",
                table: "MaterialMonuments",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "WorkerIdWorker",
                table: "Calculations",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ArticlearticleId",
                table: "ArticleUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserIdUser",
                table: "ArticleUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "ArticlearticleId",
                table: "ArticlePhotos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "PhotoPhotoId",
                table: "ArticlePhotos",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorkers_MonumentIdMonument",
                table: "MonumentWorkers",
                column: "MonumentIdMonument");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorkers_WorkerIdWorker",
                table: "MonumentWorkers",
                column: "WorkerIdWorker");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_Customerid_customer",
                table: "Monuments",
                column: "Customerid_customer");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_PhotoPhotoId",
                table: "Monuments",
                column: "PhotoPhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonuments_MaterialIdMaterial",
                table: "MaterialMonuments",
                column: "MaterialIdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonuments_MonumentIdMonument",
                table: "MaterialMonuments",
                column: "MonumentIdMonument");

            migrationBuilder.CreateIndex(
                name: "IX_Calculations_WorkerIdWorker",
                table: "Calculations",
                column: "WorkerIdWorker");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUsers_ArticlearticleId",
                table: "ArticleUsers",
                column: "ArticlearticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUsers_UserIdUser",
                table: "ArticleUsers",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePhotos_ArticlearticleId",
                table: "ArticlePhotos",
                column: "ArticlearticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePhotos_PhotoPhotoId",
                table: "ArticlePhotos",
                column: "PhotoPhotoId");

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlePhotos_Articles_ArticlearticleId",
                table: "ArticlePhotos",
                column: "ArticlearticleId",
                principalTable: "Articles",
                principalColumn: "articleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticlePhotos_Photos_PhotoPhotoId",
                table: "ArticlePhotos",
                column: "PhotoPhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleUsers_Articles_ArticlearticleId",
                table: "ArticleUsers",
                column: "ArticlearticleId",
                principalTable: "Articles",
                principalColumn: "articleId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_ArticleUsers_Users_UserIdUser",
                table: "ArticleUsers",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Calculations_Workers_WorkerIdWorker",
                table: "Calculations",
                column: "WorkerIdWorker",
                principalTable: "Workers",
                principalColumn: "IdWorker",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialMonuments_Materials_MaterialIdMaterial",
                table: "MaterialMonuments",
                column: "MaterialIdMaterial",
                principalTable: "Materials",
                principalColumn: "IdMaterial",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MaterialMonuments_Monuments_MonumentIdMonument",
                table: "MaterialMonuments",
                column: "MonumentIdMonument",
                principalTable: "Monuments",
                principalColumn: "IdMonument",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monuments_Customers_Customerid_customer",
                table: "Monuments",
                column: "Customerid_customer",
                principalTable: "Customers",
                principalColumn: "id_customer",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Monuments_Photos_PhotoPhotoId",
                table: "Monuments",
                column: "PhotoPhotoId",
                principalTable: "Photos",
                principalColumn: "PhotoId",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonumentWorkers_Monuments_MonumentIdMonument",
                table: "MonumentWorkers",
                column: "MonumentIdMonument",
                principalTable: "Monuments",
                principalColumn: "IdMonument",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_MonumentWorkers_Workers_WorkerIdWorker",
                table: "MonumentWorkers",
                column: "WorkerIdWorker",
                principalTable: "Workers",
                principalColumn: "IdWorker",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
