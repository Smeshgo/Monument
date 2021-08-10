﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using MonumentMlyn.DAL.EF;

namespace MonumentMlyn.DAL.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.8")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Appointment", b =>
                {
                    b.Property<Guid>("IdAppointment")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateAppointment")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("Update")
                        .HasColumnType("datetime2");

                    b.HasKey("IdAppointment");

                    b.ToTable("Appointments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Article", b =>
                {
                    b.Property<Guid>("IdArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Contents")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateArticle")
                        .HasColumnType("datetime2");

                    b.Property<string>("Title")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateArticle")
                        .HasColumnType("datetime2");

                    b.HasKey("IdArticle");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.ArticleUser", b =>
                {
                    b.Property<Guid>("IdArticle")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdArticleNavigationIdArticle")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUserNavigationIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdArticle");

                    b.HasIndex("IdArticleNavigationIdArticle");

                    b.HasIndex("IdUserNavigationIdUser");

                    b.ToTable("ArticleUsers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.CategoryMaterial", b =>
                {
                    b.Property<Guid>("IdCategoryMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateCategoryMaterial")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCategoryMaterial");

                    b.ToTable("CategoryMaterials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.CategoryPhoto", b =>
                {
                    b.Property<Guid>("IdCategoryPhoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatePhotoPhoto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateCategoryPhoto")
                        .HasColumnType("datetime2");

                    b.HasKey("IdCategoryPhoto");

                    b.ToTable("CategoryPhotos");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Material", b =>
                {
                    b.Property<Guid>("IdMaterial")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Color")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("CreateMaterial")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid>("IdAppointment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdAppointmentNavigationIdAppointment")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdCategoryMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdCategoryMaterialNavigationIdCategoryMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Number")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("IdMaterial");

                    b.HasIndex("IdAppointmentNavigationIdAppointment");

                    b.HasIndex("IdCategoryMaterialNavigationIdCategoryMaterial");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.MaterialMonument", b =>
                {
                    b.Property<Guid>("IdMaterialMonument")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMaterialNavigationIdMaterial")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMonumentNavigationIdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMaterialMonument");

                    b.HasIndex("IdMaterialNavigationIdMaterial");

                    b.HasIndex("IdMonumentNavigationIdMonument");

                    b.ToTable("MaterialMonuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.Property<Guid>("IdMonument")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhotoNavigationIdPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("Id_customer")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Prise")
                        .HasColumnType("decimal(18,2)");

                    b.Property<Guid?>("Сustomerid_customer")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMonument");

                    b.HasIndex("IdPhotoNavigationIdPhoto");

                    b.HasIndex("Сustomerid_customer");

                    b.ToTable("Monuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.MonumentWorker", b =>
                {
                    b.Property<Guid>("IdMonument")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdMonumentNavigationIdMonument")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdWorker")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdWorkerNavigationIdWorker")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdMonument");

                    b.HasIndex("IdMonumentNavigationIdMonument");

                    b.HasIndex("IdWorkerNavigationIdWorker");

                    b.ToTable("MonumentWorkers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.Property<Guid>("IdPhoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreatePhoto")
                        .HasColumnType("datetime2");

                    b.Property<Guid>("IdCategoryPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdCategoryPhotoNavigationIdCategoryPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathFull")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PathMini")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatePhoto")
                        .HasColumnType("datetime2");

                    b.Property<string>("Uuid")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPhoto");

                    b.HasIndex("IdCategoryPhotoNavigationIdCategoryPhoto");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.PhotoArticle", b =>
                {
                    b.Property<Guid>("IdPhoto")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdArticle")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdArticleNavigationIdArticle")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdPhotoNavigationIdPhoto")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdPhoto");

                    b.HasIndex("IdArticleNavigationIdArticle");

                    b.HasIndex("IdPhotoNavigationIdPhoto");

                    b.ToTable("PhotoArticles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Role", b =>
                {
                    b.Property<Guid>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateRole")
                        .HasColumnType("datetime2");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateRole")
                        .HasColumnType("datetime2");

                    b.HasKey("IdRole");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.User", b =>
                {
                    b.Property<Guid>("IdUser")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("Create")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Password")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Status")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Update")
                        .HasColumnType("datetime2");

                    b.Property<DateTime?>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Usernama")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdUser");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.UserRole", b =>
                {
                    b.Property<Guid>("IdRole")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdRoleNavigationIdRole")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("IdUser")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid?>("IdUserNavigationIdUser")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("IdRole");

                    b.HasIndex("IdRoleNavigationIdRole");

                    b.HasIndex("IdUserNavigationIdUser");

                    b.ToTable("UserRoles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Worker", b =>
                {
                    b.Property<Guid>("IdWorker")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateWorcer")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("NumberOfHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Rete")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime?>("UpdateWorker")
                        .HasColumnType("datetime2");

                    b.HasKey("IdWorker");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Сustomer", b =>
                {
                    b.Property<Guid>("id_customer")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Last_name")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasMaxLength(150)
                        .HasColumnType("nvarchar(150)");

                    b.Property<DateTime>("create_user")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("update_user")
                        .HasColumnType("datetime2");

                    b.HasKey("id_customer");

                    b.ToTable("Contacts");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.ArticleUser", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Article", "IdArticleNavigation")
                        .WithMany("ArticleUsers")
                        .HasForeignKey("IdArticleNavigationIdArticle");

                    b.HasOne("MonumentMlyn.DAL.Entities.User", "IdUserNavigation")
                        .WithMany("ArticleUsers")
                        .HasForeignKey("IdUserNavigationIdUser");

                    b.Navigation("IdArticleNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Material", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Appointment", "IdAppointmentNavigation")
                        .WithMany("Materials")
                        .HasForeignKey("IdAppointmentNavigationIdAppointment");

                    b.HasOne("MonumentMlyn.DAL.Entities.CategoryMaterial", "IdCategoryMaterialNavigation")
                        .WithMany("Materials")
                        .HasForeignKey("IdCategoryMaterialNavigationIdCategoryMaterial");

                    b.Navigation("IdAppointmentNavigation");

                    b.Navigation("IdCategoryMaterialNavigation");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.MaterialMonument", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Material", "IdMaterialNavigation")
                        .WithMany("MaterialMonuments")
                        .HasForeignKey("IdMaterialNavigationIdMaterial");

                    b.HasOne("MonumentMlyn.DAL.Entities.Monument", "IdMonumentNavigation")
                        .WithMany("MaterialMonuments")
                        .HasForeignKey("IdMonumentNavigationIdMonument");

                    b.Navigation("IdMaterialNavigation");

                    b.Navigation("IdMonumentNavigation");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Photo", "IdPhotoNavigation")
                        .WithMany("Monuments")
                        .HasForeignKey("IdPhotoNavigationIdPhoto");

                    b.HasOne("MonumentMlyn.DAL.Entities.Сustomer", null)
                        .WithMany("Monuments")
                        .HasForeignKey("Сustomerid_customer");

                    b.Navigation("IdPhotoNavigation");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.MonumentWorker", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Monument", "IdMonumentNavigation")
                        .WithMany("MonumentWorkers")
                        .HasForeignKey("IdMonumentNavigationIdMonument");

                    b.HasOne("MonumentMlyn.DAL.Entities.Worker", "IdWorkerNavigation")
                        .WithMany("MonumentWorkers")
                        .HasForeignKey("IdWorkerNavigationIdWorker");

                    b.Navigation("IdMonumentNavigation");

                    b.Navigation("IdWorkerNavigation");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.CategoryPhoto", "IdCategoryPhotoNavigation")
                        .WithMany("Photos")
                        .HasForeignKey("IdCategoryPhotoNavigationIdCategoryPhoto");

                    b.Navigation("IdCategoryPhotoNavigation");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.PhotoArticle", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Article", "IdArticleNavigation")
                        .WithMany("PhotoArticles")
                        .HasForeignKey("IdArticleNavigationIdArticle");

                    b.HasOne("MonumentMlyn.DAL.Entities.Photo", "IdPhotoNavigation")
                        .WithMany("PhotoArticles")
                        .HasForeignKey("IdPhotoNavigationIdPhoto");

                    b.Navigation("IdArticleNavigation");

                    b.Navigation("IdPhotoNavigation");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.UserRole", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Role", "IdRoleNavigation")
                        .WithMany("UserRoles")
                        .HasForeignKey("IdRoleNavigationIdRole");

                    b.HasOne("MonumentMlyn.DAL.Entities.User", "IdUserNavigation")
                        .WithMany("UserRoles")
                        .HasForeignKey("IdUserNavigationIdUser");

                    b.Navigation("IdRoleNavigation");

                    b.Navigation("IdUserNavigation");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Appointment", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Article", b =>
                {
                    b.Navigation("ArticleUsers");

                    b.Navigation("PhotoArticles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.CategoryMaterial", b =>
                {
                    b.Navigation("Materials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.CategoryPhoto", b =>
                {
                    b.Navigation("Photos");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Material", b =>
                {
                    b.Navigation("MaterialMonuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.Navigation("MaterialMonuments");

                    b.Navigation("MonumentWorkers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.Navigation("Monuments");

                    b.Navigation("PhotoArticles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Role", b =>
                {
                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.User", b =>
                {
                    b.Navigation("ArticleUsers");

                    b.Navigation("UserRoles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Worker", b =>
                {
                    b.Navigation("MonumentWorkers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Сustomer", b =>
                {
                    b.Navigation("Monuments");
                });
#pragma warning restore 612, 618
        }
    }
}
