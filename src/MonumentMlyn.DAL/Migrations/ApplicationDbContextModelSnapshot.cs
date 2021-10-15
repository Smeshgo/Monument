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
                .HasAnnotation("ProductVersion", "5.0.9")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ArticlePhoto", b =>
                {
                    b.Property<Guid>("ArticlesArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhotosPhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticlesArticleId", "PhotosPhotoId");

                    b.HasIndex("PhotosPhotoId");

                    b.ToTable("ArticlePhoto");
                });

            modelBuilder.Entity("ArticleUser", b =>
                {
                    b.Property<Guid>("ArticleId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("UsersUserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("ArticleId", "UsersUserId");

                    b.HasIndex("UsersUserId");

                    b.ToTable("ArticleUser");
                });

            modelBuilder.Entity("MaterialMonument", b =>
                {
                    b.Property<Guid>("MaterialsMaterialId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("MonumentsMonumentId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MaterialsMaterialId", "MonumentsMonumentId");

                    b.HasIndex("MonumentsMonumentId");

                    b.ToTable("MaterialMonument");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Article", b =>
                {
                    b.Property<Guid>("ArticleId")
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

                    b.HasKey("ArticleId");

                    b.ToTable("Articles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Customer", b =>
                {
                    b.Property<Guid>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime>("CreateUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Surname")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Material", b =>
                {
                    b.Property<Guid>("MaterialId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("Appointment")
                        .HasColumnType("int");

                    b.Property<int>("Category")
                        .HasColumnType("int");

                    b.Property<int>("Color")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreateMaterial")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Height")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Length")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Number")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Status")
                        .HasColumnType("int");

                    b.Property<DateTime?>("UpdateMaterial")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("Width")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MaterialId");

                    b.ToTable("Materials");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.Property<Guid>("MonumentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("CustomerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("PhotoId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("MonumentId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("PhotoId");

                    b.ToTable("Monuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.Property<Guid>("PhotoId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<int>("CategoryPhoto")
                        .HasColumnType("int");

                    b.Property<DateTime?>("CreatePhoto")
                        .HasColumnType("datetime2");

                    b.Property<byte[]>("FullPhoto")
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("MinyPhoto")
                        .HasColumnType("varbinary(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdatePhoto")
                        .HasColumnType("datetime2");

                    b.HasKey("PhotoId");

                    b.ToTable("Photos");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Role", b =>
                {
                    b.Property<Guid>("RoleId")
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

                    b.HasKey("RoleId");

                    b.ToTable("Roles");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Salary", b =>
                {
                    b.Property<DateTime>("Date")
                        .HasColumnType("Date");

                    b.Property<Guid>("WorkerId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<decimal>("Advance")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NumberOfHours")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Rate")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Date", "WorkerId");

                    b.HasIndex("WorkerId");

                    b.ToTable("Salaries");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.User", b =>
                {
                    b.Property<Guid>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

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

                    b.Property<DateTime?>("UpdateUser")
                        .HasColumnType("datetime2");

                    b.Property<string>("UserName")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("UserId");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Worker", b =>
                {
                    b.Property<Guid>("WorkerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<DateTime?>("CreateWorker")
                        .HasColumnType("datetime2");

                    b.Property<string>("FirstName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("UpdateWorker")
                        .HasColumnType("datetime2");

                    b.HasKey("WorkerId");

                    b.ToTable("Workers");
                });

            modelBuilder.Entity("MonumentWorker", b =>
                {
                    b.Property<Guid>("MonumentWorkersMonumentId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("WorkersWorkerId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("MonumentWorkersMonumentId", "WorkersWorkerId");

                    b.HasIndex("WorkersWorkerId");

                    b.ToTable("MonumentWorker");
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.Property<Guid>("RoleUsersUserId")
                        .HasColumnType("uniqueidentifier");

                    b.Property<Guid>("RolesRoleId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("RoleUsersUserId", "RolesRoleId");

                    b.HasIndex("RolesRoleId");

                    b.ToTable("RoleUser");
                });

            modelBuilder.Entity("ArticlePhoto", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticlesArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.Photo", null)
                        .WithMany()
                        .HasForeignKey("PhotosPhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ArticleUser", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Article", null)
                        .WithMany()
                        .HasForeignKey("ArticleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("UsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MaterialMonument", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Material", null)
                        .WithMany()
                        .HasForeignKey("MaterialsMaterialId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.Monument", null)
                        .WithMany()
                        .HasForeignKey("MonumentsMonumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Monument", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Customer", "Customer")
                        .WithMany("Monuments")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.Photo", "Photo")
                        .WithMany("Monument")
                        .HasForeignKey("PhotoId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");

                    b.Navigation("Photo");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Salary", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Worker", "Worker")
                        .WithMany("Salary")
                        .HasForeignKey("WorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Worker");
                });

            modelBuilder.Entity("MonumentWorker", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.Monument", null)
                        .WithMany()
                        .HasForeignKey("MonumentWorkersMonumentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.Worker", null)
                        .WithMany()
                        .HasForeignKey("WorkersWorkerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("RoleUser", b =>
                {
                    b.HasOne("MonumentMlyn.DAL.Entities.User", null)
                        .WithMany()
                        .HasForeignKey("RoleUsersUserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("MonumentMlyn.DAL.Entities.Role", null)
                        .WithMany()
                        .HasForeignKey("RolesRoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Customer", b =>
                {
                    b.Navigation("Monuments");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Photo", b =>
                {
                    b.Navigation("Monument");
                });

            modelBuilder.Entity("MonumentMlyn.DAL.Entities.Worker", b =>
                {
                    b.Navigation("Salary");
                });
#pragma warning restore 612, 618
        }
    }
}
