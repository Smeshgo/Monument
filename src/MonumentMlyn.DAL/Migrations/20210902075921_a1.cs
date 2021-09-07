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
                    IdArticle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Contents = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateArticle = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateArticle = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Articles", x => x.IdArticle);
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
                    Color = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Width = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Number = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Status = table.Column<string>(type: "nvarchar(max)", nullable: true),
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
                    IdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FullPhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    MinyPhoto = table.Column<byte[]>(type: "varbinary(max)", nullable: true),
                    CreatePhoto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatePhoto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    CategoryPhoto = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.IdPhoto);
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
                    NumberOfHours = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Rete = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateWorcer = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateWorker = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Workers", x => x.IdWorker);
                });

            migrationBuilder.CreateTable(
                name: "ArticlePhoto",
                columns: table => new
                {
                    ArticlesIdArticle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoIdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePhoto", x => new { x.ArticlesIdArticle, x.PhotoIdPhoto });
                    table.ForeignKey(
                        name: "FK_ArticlePhoto_Articles_ArticlesIdArticle",
                        column: x => x.ArticlesIdArticle,
                        principalTable: "Articles",
                        principalColumn: "IdArticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlePhoto_Photos_PhotoIdPhoto",
                        column: x => x.PhotoIdPhoto,
                        principalTable: "Photos",
                        principalColumn: "IdPhoto",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Monuments",
                columns: table => new
                {
                    IdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_customer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoIdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
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
                        name: "FK_Monuments_Photos_PhotoIdPhoto",
                        column: x => x.PhotoIdPhoto,
                        principalTable: "Photos",
                        principalColumn: "IdPhoto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleUser",
                columns: table => new
                {
                    ArticlesIdArticle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserIdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleUser", x => new { x.ArticlesIdArticle, x.UserIdUser });
                    table.ForeignKey(
                        name: "FK_ArticleUser_Articles_ArticlesIdArticle",
                        column: x => x.ArticlesIdArticle,
                        principalTable: "Articles",
                        principalColumn: "IdArticle",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticleUser_Users_UserIdUser",
                        column: x => x.UserIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RoleUser",
                columns: table => new
                {
                    RolesIdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UsersIdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RoleUser", x => new { x.RolesIdRole, x.UsersIdUser });
                    table.ForeignKey(
                        name: "FK_RoleUser_Roles_RolesIdRole",
                        column: x => x.RolesIdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RoleUser_Users_UsersIdUser",
                        column: x => x.UsersIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MaterialMonument",
                columns: table => new
                {
                    MaterialsIdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    MonumentsIdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialMonument", x => new { x.MaterialsIdMaterial, x.MonumentsIdMonument });
                    table.ForeignKey(
                        name: "FK_MaterialMonument_Materials_MaterialsIdMaterial",
                        column: x => x.MaterialsIdMaterial,
                        principalTable: "Materials",
                        principalColumn: "IdMaterial",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MaterialMonument_Monuments_MonumentsIdMonument",
                        column: x => x.MonumentsIdMonument,
                        principalTable: "Monuments",
                        principalColumn: "IdMonument",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MonumentWorker",
                columns: table => new
                {
                    MonumentsIdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    WorkersIdWorker = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonumentWorker", x => new { x.MonumentsIdMonument, x.WorkersIdWorker });
                    table.ForeignKey(
                        name: "FK_MonumentWorker_Monuments_MonumentsIdMonument",
                        column: x => x.MonumentsIdMonument,
                        principalTable: "Monuments",
                        principalColumn: "IdMonument",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MonumentWorker_Workers_WorkersIdWorker",
                        column: x => x.WorkersIdWorker,
                        principalTable: "Workers",
                        principalColumn: "IdWorker",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePhoto_PhotoIdPhoto",
                table: "ArticlePhoto",
                column: "PhotoIdPhoto");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUser_UserIdUser",
                table: "ArticleUser",
                column: "UserIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonument_MonumentsIdMonument",
                table: "MaterialMonument",
                column: "MonumentsIdMonument");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_Customerid_customer",
                table: "Monuments",
                column: "Customerid_customer");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_PhotoIdPhoto",
                table: "Monuments",
                column: "PhotoIdPhoto");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorker_WorkersIdWorker",
                table: "MonumentWorker",
                column: "WorkersIdWorker");

            migrationBuilder.CreateIndex(
                name: "IX_RoleUser_UsersIdUser",
                table: "RoleUser",
                column: "UsersIdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlePhoto");

            migrationBuilder.DropTable(
                name: "ArticleUser");

            migrationBuilder.DropTable(
                name: "MaterialMonument");

            migrationBuilder.DropTable(
                name: "MonumentWorker");

            migrationBuilder.DropTable(
                name: "RoleUser");

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
