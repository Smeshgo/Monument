using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace MonumentMlyn.DAL.Migrations
{
    public partial class a7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlePhotos");

            migrationBuilder.CreateTable(
                name: "ArticlePhoto",
                columns: table => new
                {
                    ArticlesArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotosPhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePhoto", x => new { x.ArticlesArticleId, x.PhotosPhotoId });
                    table.ForeignKey(
                        name: "FK_ArticlePhoto_Articles_ArticlesArticleId",
                        column: x => x.ArticlesArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlePhoto_Photos_PhotosPhotoId",
                        column: x => x.PhotosPhotoId,
                        principalTable: "Photos",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePhoto_PhotosPhotoId",
                table: "ArticlePhoto",
                column: "PhotosPhotoId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "ArticlePhoto");

            migrationBuilder.CreateTable(
                name: "ArticlePhotos",
                columns: table => new
                {
                    ArticleId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    PhotoId = table.Column<Guid>(type: "uniqueidentifier", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ArticlePhotos", x => new { x.ArticleId, x.PhotoId });
                    table.ForeignKey(
                        name: "FK_ArticlePhotos_Articles_ArticleId",
                        column: x => x.ArticleId,
                        principalTable: "Articles",
                        principalColumn: "ArticleId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ArticlePhotos_Photos_PhotoId",
                        column: x => x.PhotoId,
                        principalTable: "Photos",
                        principalColumn: "PhotoId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ArticlePhotos_PhotoId",
                table: "ArticlePhotos",
                column: "PhotoId");
        }
    }
}
