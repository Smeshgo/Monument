using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleUsers_Roles_RoleIdRole",
                table: "RoleUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleUsers_Users_UserIdUser",
                table: "RoleUsers");

            migrationBuilder.DropIndex(
                name: "IX_RoleUsers_RoleIdRole",
                table: "RoleUsers");

            migrationBuilder.DropIndex(
                name: "IX_RoleUsers_UserIdUser",
                table: "RoleUsers");

            migrationBuilder.DropColumn(
                name: "RoleIdRole",
                table: "RoleUsers");

            migrationBuilder.DropColumn(
                name: "UserIdUser",
                table: "RoleUsers");

            migrationBuilder.RenameColumn(
                name: "IdUser",
                table: "RoleUsers",
                newName: "UserId");

            migrationBuilder.RenameColumn(
                name: "IdRole",
                table: "RoleUsers",
                newName: "RoleId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_UserId",
                table: "RoleUsers",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleUsers_Roles_RoleId",
                table: "RoleUsers",
                column: "RoleId",
                principalTable: "Roles",
                principalColumn: "IdRole",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleUsers_Users_UserId",
                table: "RoleUsers",
                column: "UserId",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_RoleUsers_Roles_RoleId",
                table: "RoleUsers");

            migrationBuilder.DropForeignKey(
                name: "FK_RoleUsers_Users_UserId",
                table: "RoleUsers");

            migrationBuilder.DropIndex(
                name: "IX_RoleUsers_UserId",
                table: "RoleUsers");

            migrationBuilder.RenameColumn(
                name: "UserId",
                table: "RoleUsers",
                newName: "IdUser");

            migrationBuilder.RenameColumn(
                name: "RoleId",
                table: "RoleUsers",
                newName: "IdRole");

            migrationBuilder.AddColumn<Guid>(
                name: "RoleIdRole",
                table: "RoleUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.AddColumn<Guid>(
                name: "UserIdUser",
                table: "RoleUsers",
                type: "uniqueidentifier",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_RoleIdRole",
                table: "RoleUsers",
                column: "RoleIdRole");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_UserIdUser",
                table: "RoleUsers",
                column: "UserIdUser");

            migrationBuilder.AddForeignKey(
                name: "FK_RoleUsers_Roles_RoleIdRole",
                table: "RoleUsers",
                column: "RoleIdRole",
                principalTable: "Roles",
                principalColumn: "IdRole",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_RoleUsers_Users_UserIdUser",
                table: "RoleUsers",
                column: "UserIdUser",
                principalTable: "Users",
                principalColumn: "IdUser",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
