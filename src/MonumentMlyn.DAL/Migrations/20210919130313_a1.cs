using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Articles",
                columns: table => new
                {
                    articleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateArticle = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateArticle = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.articleId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id_customer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    create_user = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_user = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id_customer);
                });

            migrationBuilder.CreateTable(
                name: "Materials",
                columns: table => new
                {
                    IdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Height = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Length = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Color = table.Column<int>(type: "int", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Number = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<int>(type: "int", nullable: false),
                    Appointment = table.Column<int>(type: "int", nullable: false),
                    Category = table.Column<int>(type: "int", nullable: false),
                    CreateMaterial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateMaterial = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.IdMaterial);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    PhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullPhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MinyPhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatePhoto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatePhoto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryPhoto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.PhotoId);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateRole = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateRole = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.IdRole);
                });

            migrationBuilder.CreateTable(
                name: "Users",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateUser = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUser = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Users", x => x.IdUser);
                });

            migrationBuilder.CreateTable(
                name: "Workers",
                columns: table => new
                {
                    IdWorker = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateWorcer = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateWorker = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.IdWorker);
                });

            migrationBuilder.CreateTable(
                name: "ArticlePhotos",
                columns: table => new
                {
                    PhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    articleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoPhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    ArticlearticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePhotos", x => new { x.articleId, x.PhotoId });
                    table.ForeignKey(
                        name: "FK_ArticlePhotos_Articles_ArticlearticleId",
                        column: x => x.ArticlearticleId,
                        principalTable: "Articles",
                        principalColumn: "articleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticlePhotos_Photos_PhotoPhotoId",
                        column: x => x.PhotoPhotoId,
                        principalTable: "Photos",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monuments",
                columns: table => new
                {
                    IdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    PhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_customer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoPhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Customerid_customer = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monuments", x => x.IdMonument);
                    table.ForeignKey(
                        name: "FK_Monuments_Customers_Customerid_customer",
                        column: x => x.Customerid_customer,
                        principalTable: "Customers",
                        principalColumn: "id_customer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monuments_Photos_PhotoPhotoId",
                        column: x => x.PhotoPhotoId,
                        principalTable: "Photos",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleUsers",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    articleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    ArticlearticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserIdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleUsers", x => new { x.articleId, x.IdUser });
                    table.ForeignKey(
                        name: "FK_ArticleUsers_Articles_ArticlearticleId",
                        column: x => x.ArticlearticleId,
                        principalTable: "Articles",
                        principalColumn: "articleId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticleUsers_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RoleIdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RoleIdRole, x.UserIdUser });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RoleIdRole",
                        column: x => x.RoleIdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUsers",
                columns: table => new
                {
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    RoleIdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserIdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUsers", x => new { x.IdRole, x.IdUser });
                    table.ForeignKey(
                        name: "FK_RoleUsers_Roles_RoleIdRole",
                        column: x => x.RoleIdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_RoleUsers_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Calculations",
                columns: table => new
                {
                    IdWorker = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Advance = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    NumberOfHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rete = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    WorkerIdWorker = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Calculations", x => new { x.IdWorker, x.Date });
                    table.ForeignKey(
                        name: "FK_Calculations_Workers_WorkerIdWorker",
                        column: x => x.WorkerIdWorker,
                        principalTable: "Workers",
                        principalColumn: "IdWorker",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialMonuments",
                columns: table => new
                {
                    IdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonumentIdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MaterialIdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialMonuments", x => new { x.IdMaterial, x.IdMonument });
                    table.ForeignKey(
                        name: "FK_MaterialMonuments_Materials_MaterialIdMaterial",
                        column: x => x.MaterialIdMaterial,
                        principalTable: "Materials",
                        principalColumn: "IdMaterial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialMonuments_Monuments_MonumentIdMonument",
                        column: x => x.MonumentIdMonument,
                        principalTable: "Monuments",
                        principalColumn: "IdMonument",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonumentWorkers",
                columns: table => new
                {
                    IdWorker = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkerIdWorker = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    MonumentIdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonumentWorkers", x => new { x.IdMonument, x.IdWorker });
                    table.ForeignKey(
                        name: "FK_MonumentWorkers_Monuments_MonumentIdMonument",
                        column: x => x.MonumentIdMonument,
                        principalTable: "Monuments",
                        principalColumn: "IdMonument",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonumentWorkers_Workers_WorkerIdWorker",
                        column: x => x.WorkerIdWorker,
                        principalTable: "Workers",
                        principalColumn: "IdWorker",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePhotos_ArticlearticleId",
                table: "ArticlePhotos",
                column: "ArticlearticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePhotos_PhotoPhotoId",
                table: "ArticlePhotos",
                column: "PhotoPhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUsers_ArticlearticleId",
                table: "ArticleUsers",
                column: "ArticlearticleId");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUsers_UserIdUser",
                table: "ArticleUsers",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_Calculations_WorkerIdWorker",
                table: "Calculations",
                column: "WorkerIdWorker");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonuments_MaterialIdMaterial",
                table: "MaterialMonuments",
                column: "MaterialIdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonuments_MonumentIdMonument",
                table: "MaterialMonuments",
                column: "MonumentIdMonument");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_Customerid_customer",
                table: "Monuments",
                column: "Customerid_customer");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_PhotoPhotoId",
                table: "Monuments",
                column: "PhotoPhotoId");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorkers_MonumentIdMonument",
                table: "MonumentWorkers",
                column: "MonumentIdMonument");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorkers_WorkerIdWorker",
                table: "MonumentWorkers",
                column: "WorkerIdWorker");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UserIdUser",
                table: "RoleUser",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_RoleIdRole",
                table: "RoleUsers",
                column: "RoleIdRole");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUsers_UserIdUser",
                table: "RoleUsers",
                column: "UserIdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlePhotos");

            migrationBuilder.DropTable(
                name: "ArticleUsers");

            migrationBuilder.DropTable(
                name: "Calculations");

            migrationBuilder.DropTable(
                name: "MaterialMonuments");

            migrationBuilder.DropTable(
                name: "MonumentWorkers");

            migrationBuilder.DropTable(
                name: "RoleUser");

            migrationBuilder.DropTable(
                name: "RoleUsers");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Monuments");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Photos");
        }
    }
}
