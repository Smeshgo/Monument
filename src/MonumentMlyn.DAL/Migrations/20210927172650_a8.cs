using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a8 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleUsers");

            migrationBuilder.DropTable(
                name: "MaterialMonuments");

            migrationBuilder.DropTable(
                name: "MonumentWorkers");

            migrationBuilder.DropTable(
                name: "RoleUsers");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations");

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

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations",
                columns: new[] { "Date", "WorkerId" });

            migrationBuilder.CreateTable(
                name: "ArticleUser",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleUser", x => new { x.ArticleId, x.UsersUserId });
                    table.ForeignKey(
                        name: "FK_ArticleUser_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleUser_Users_UsersUserId",
                        column: x => x.UsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonumentWorker",
                columns: table => new
                {
                    MonumentWorkersMonumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkersWorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonumentWorker", x => new { x.MonumentWorkersMonumentId, x.WorkersWorkerId });
                    table.ForeignKey(
                        name: "FK_MonumentWorker_Monuments_MonumentWorkersMonumentId",
                        column: x => x.MonumentWorkersMonumentId,
                        principalTable: "Monuments",
                        principalColumn: "MonumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonumentWorker_Workers_WorkersWorkerId",
                        column: x => x.WorkersWorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RoleUsersUserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RolesRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RoleUsersUserId, x.RolesRoleId });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesRoleId",
                        column: x => x.RolesRoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_RoleUsersUserId",
                        column: x => x.RoleUsersUserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MaterialId1",
                table: "Materials",
                column: "MaterialId1");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_MonumentId",
                table: "Materials",
                column: "MonumentId");

            migrationBuilder.CreateIndex(
                name: "IX_Calculations_WorkerId",
                table: "Calculations",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUser_UsersUserId",
                table: "ArticleUser",
                column: "UsersUserId");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorker_WorkersWorkerId",
                table: "MonumentWorker",
                column: "WorkersWorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_RolesRoleId",
                table: "RoleUser",
                column: "RolesRoleId");

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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Materials_MaterialId1",
                table: "Materials");

            migrationBuilder.DropForeignKey(
                name: "FK_Materials_Monuments_MonumentId",
                table: "Materials");

            migrationBuilder.DropTable(
                name: "ArticleUser");

            migrationBuilder.DropTable(
                name: "MonumentWorker");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropIndex(
                name: "IX_Materials_MaterialId1",
                table: "Materials");

            migrationBuilder.DropIndex(
                name: "IX_Materials_MonumentId",
                table: "Materials");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations");

            migrationBuilder.DropIndex(
                name: "IX_Calculations_WorkerId",
                table: "Calculations");

            migrationBuilder.DropColumn(
                name: "MaterialId1",
                table: "Materials");

            migrationBuilder.DropColumn(
                name: "MonumentId",
                table: "Materials");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Calculations",
                table: "Calculations",
                columns: new[] { "WorkerId", "Date" });

            migrationBuilder.CreateTable(
                name: "ArticleUsers",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleUsers", x => new { x.ArticleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_ArticleUsers_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialMonuments",
                columns: table => new
                {
                    MaterialId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialMonuments", x => new { x.MaterialId, x.MonumentId });
                    table.ForeignKey(
                        name: "FK_MaterialMonuments_Materials_MaterialId",
                        column: x => x.MaterialId,
                        principalTable: "Materials",
                        principalColumn: "MaterialId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialMonuments_Monuments_MonumentId",
                        column: x => x.MonumentId,
                        principalTable: "Monuments",
                        principalColumn: "MonumentId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonumentWorkers",
                columns: table => new
                {
                    MonumentId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkerId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonumentWorkers", x => new { x.MonumentId, x.WorkerId });
                    table.ForeignKey(
                        name: "FK_MonumentWorkers_Monuments_MonumentId",
                        column: x => x.MonumentId,
                        principalTable: "Monuments",
                        principalColumn: "MonumentId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonumentWorkers_Workers_WorkerId",
                        column: x => x.WorkerId,
                        principalTable: "Workers",
                        principalColumn: "WorkerId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUsers",
                columns: table => new
                {
                    RoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUsers", x => new { x.RoleId, x.UserId });
                    table.ForeignKey(
                        name: "FK_RoleUsers_Roles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "Roles",
                        principalColumn: "RoleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUsers_Users_UserId",
                        column: x => x.UserId,
                        principalTable: "Users",
                        principalColumn: "UserId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUsers_UserId",
                table: "ArticleUsers",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonuments_MonumentId",
                table: "MaterialMonuments",
                column: "MonumentId");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorkers_WorkerId",
                table: "MonumentWorkers",
                column: "WorkerId");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_UserId",
                table: "RoleUsers",
                column: "UserId");
        }
    }
}
