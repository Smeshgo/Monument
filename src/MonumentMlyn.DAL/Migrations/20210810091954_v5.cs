using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class v5 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Appointments",
                columns: table => new
                {
                    IdAppointment = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateAppointment = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Appointments", x => x.IdAppointment);
                });

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
                name: "CategoryMaterials",
                columns: table => new
                {
                    IdCategoryMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreateCategoryMaterial = table.Column<DateTime>(type: "datetime2", nullable: true)
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
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatePhotoPhoto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateCategoryPhoto = table.Column<DateTime>(type: "datetime2", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CategoryPhotos", x => x.IdCategoryPhoto);
                });

            migrationBuilder.CreateTable(
                name: "Contacts",
                columns: table => new
                {
                    id_customer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Last_name = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    create_user = table.Column<DateTime>(type: "datetime2", nullable: false),
                    update_user = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Contacts", x => x.id_customer);
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
                    Usernama = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Update = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Create = table.Column<DateTime>(type: "datetime2", nullable: false),
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
                    CreateMaterial = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdateUser = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdAppointment = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCategoryMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdAppointmentNavigationIdAppointment = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdCategoryMaterialNavigationIdCategoryMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Materials", x => x.IdMaterial);
                    table.ForeignKey(
                        name: "FK_Materials_Appointments_IdAppointmentNavigationIdAppointment",
                        column: x => x.IdAppointmentNavigationIdAppointment,
                        principalTable: "Appointments",
                        principalColumn: "IdAppointment",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Materials_CategoryMaterials_IdCategoryMaterialNavigationIdCategoryMaterial",
                        column: x => x.IdCategoryMaterialNavigationIdCategoryMaterial,
                        principalTable: "CategoryMaterials",
                        principalColumn: "IdCategoryMaterial",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Photos",
                columns: table => new
                {
                    IdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathFull = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PathMini = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Uuid = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    CreatePhoto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    UpdatePhoto = table.Column<DateTime>(type: "datetime2", nullable: true),
                    IdCategoryPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdCategoryPhotoNavigationIdCategoryPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Photos", x => x.IdPhoto);
                    table.ForeignKey(
                        name: "FK_Photos_CategoryPhotos_IdCategoryPhotoNavigationIdCategoryPhoto",
                        column: x => x.IdCategoryPhotoNavigationIdCategoryPhoto,
                        principalTable: "CategoryPhotos",
                        principalColumn: "IdCategoryPhoto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "ArticleUsers",
                columns: table => new
                {
                    IdArticle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdArticleNavigationIdArticle = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUserNavigationIdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticleUsers", x => x.IdArticle);
                    table.ForeignKey(
                        name: "FK_ArticleUsers_Articles_IdArticleNavigationIdArticle",
                        column: x => x.IdArticleNavigationIdArticle,
                        principalTable: "Articles",
                        principalColumn: "IdArticle",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ArticleUsers_Users_IdUserNavigationIdUser",
                        column: x => x.IdUserNavigationIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "UserRoles",
                columns: table => new
                {
                    IdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdRoleNavigationIdRole = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdUserNavigationIdUser = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserRoles", x => x.IdRole);
                    table.ForeignKey(
                        name: "FK_UserRoles_Roles_IdRoleNavigationIdRole",
                        column: x => x.IdRoleNavigationIdRole,
                        principalTable: "Roles",
                        principalColumn: "IdRole",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_UserRoles_Users_IdUserNavigationIdUser",
                        column: x => x.IdUserNavigationIdUser,
                        principalTable: "Users",
                        principalColumn: "IdUser",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Monuments",
                columns: table => new
                {
                    IdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Prise = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    IdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id_customer = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdPhotoNavigationIdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    Сustomerid_customer = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Monuments", x => x.IdMonument);
                    table.ForeignKey(
                        name: "FK_Monuments_Contacts_Сustomerid_customer",
                        column: x => x.Сustomerid_customer,
                        principalTable: "Contacts",
                        principalColumn: "id_customer",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Monuments_Photos_IdPhotoNavigationIdPhoto",
                        column: x => x.IdPhotoNavigationIdPhoto,
                        principalTable: "Photos",
                        principalColumn: "IdPhoto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "PhotoArticles",
                columns: table => new
                {
                    IdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdArticle = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdArticleNavigationIdArticle = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdPhotoNavigationIdPhoto = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhotoArticles", x => x.IdPhoto);
                    table.ForeignKey(
                        name: "FK_PhotoArticles_Articles_IdArticleNavigationIdArticle",
                        column: x => x.IdArticleNavigationIdArticle,
                        principalTable: "Articles",
                        principalColumn: "IdArticle",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_PhotoArticles_Photos_IdPhotoNavigationIdPhoto",
                        column: x => x.IdPhotoNavigationIdPhoto,
                        principalTable: "Photos",
                        principalColumn: "IdPhoto",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MaterialMonuments",
                columns: table => new
                {
                    IdMaterialMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMaterialNavigationIdMaterial = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdMonumentNavigationIdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MaterialMonuments", x => x.IdMaterialMonument);
                    table.ForeignKey(
                        name: "FK_MaterialMonuments_Materials_IdMaterialNavigationIdMaterial",
                        column: x => x.IdMaterialNavigationIdMaterial,
                        principalTable: "Materials",
                        principalColumn: "IdMaterial",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MaterialMonuments_Monuments_IdMonumentNavigationIdMonument",
                        column: x => x.IdMonumentNavigationIdMonument,
                        principalTable: "Monuments",
                        principalColumn: "IdMonument",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "MonumentWorkers",
                columns: table => new
                {
                    IdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdWorker = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    IdMonumentNavigationIdMonument = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    IdWorkerNavigationIdWorker = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MonumentWorkers", x => x.IdMonument);
                    table.ForeignKey(
                        name: "FK_MonumentWorkers_Monuments_IdMonumentNavigationIdMonument",
                        column: x => x.IdMonumentNavigationIdMonument,
                        principalTable: "Monuments",
                        principalColumn: "IdMonument",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_MonumentWorkers_Workers_IdWorkerNavigationIdWorker",
                        column: x => x.IdWorkerNavigationIdWorker,
                        principalTable: "Workers",
                        principalColumn: "IdWorker",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUsers_IdArticleNavigationIdArticle",
                table: "ArticleUsers",
                column: "IdArticleNavigationIdArticle");

            migrationBuilder.CreateIndex(
                name: "IX_ArticleUsers_IdUserNavigationIdUser",
                table: "ArticleUsers",
                column: "IdUserNavigationIdUser");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonuments_IdMaterialNavigationIdMaterial",
                table: "MaterialMonuments",
                column: "IdMaterialNavigationIdMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_MaterialMonuments_IdMonumentNavigationIdMonument",
                table: "MaterialMonuments",
                column: "IdMonumentNavigationIdMonument");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_IdAppointmentNavigationIdAppointment",
                table: "Materials",
                column: "IdAppointmentNavigationIdAppointment");

            migrationBuilder.CreateIndex(
                name: "IX_Materials_IdCategoryMaterialNavigationIdCategoryMaterial",
                table: "Materials",
                column: "IdCategoryMaterialNavigationIdCategoryMaterial");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_Сustomerid_customer",
                table: "Monuments",
                column: "Сustomerid_customer");

            migrationBuilder.CreateIndex(
                name: "IX_Monuments_IdPhotoNavigationIdPhoto",
                table: "Monuments",
                column: "IdPhotoNavigationIdPhoto");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorkers_IdMonumentNavigationIdMonument",
                table: "MonumentWorkers",
                column: "IdMonumentNavigationIdMonument");

            migrationBuilder.CreateIndex(
                name: "IX_MonumentWorkers_IdWorkerNavigationIdWorker",
                table: "MonumentWorkers",
                column: "IdWorkerNavigationIdWorker");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoArticles_IdArticleNavigationIdArticle",
                table: "PhotoArticles",
                column: "IdArticleNavigationIdArticle");

            migrationBuilder.CreateIndex(
                name: "IX_PhotoArticles_IdPhotoNavigationIdPhoto",
                table: "PhotoArticles",
                column: "IdPhotoNavigationIdPhoto");

            migrationBuilder.CreateIndex(
                name: "IX_Photos_IdCategoryPhotoNavigationIdCategoryPhoto",
                table: "Photos",
                column: "IdCategoryPhotoNavigationIdCategoryPhoto");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_IdRoleNavigationIdRole",
                table: "UserRoles",
                column: "IdRoleNavigationIdRole");

            migrationBuilder.CreateIndex(
                name: "IX_UserRoles_IdUserNavigationIdUser",
                table: "UserRoles",
                column: "IdUserNavigationIdUser");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticleUsers");

            migrationBuilder.DropTable(
                name: "MaterialMonuments");

            migrationBuilder.DropTable(
                name: "MonumentWorkers");

            migrationBuilder.DropTable(
                name: "PhotoArticles");

            migrationBuilder.DropTable(
                name: "UserRoles");

            migrationBuilder.DropTable(
                name: "Materials");

            migrationBuilder.DropTable(
                name: "Monuments");

            migrationBuilder.DropTable(
                name: "Workers");

            migrationBuilder.DropTable(
                name: "Articles");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "Users");

            migrationBuilder.DropTable(
                name: "Appointments");

            migrationBuilder.DropTable(
                name: "CategoryMaterials");

            migrationBuilder.DropTable(
                name: "Contacts");

            migrationBuilder.DropTable(
                name: "Photos");

            migrationBuilder.DropTable(
                name: "CategoryPhotos");
        }
    }
}
