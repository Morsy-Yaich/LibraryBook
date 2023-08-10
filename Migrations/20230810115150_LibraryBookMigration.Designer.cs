﻿// <auto-generated />
using System;
using LibraryBook.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace LibraryBook.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20230810115150_LibraryBookMigration")]
    partial class LibraryBookMigration
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("LibraryBook.Models.Auteur", b =>
                {
                    b.Property<int>("IdAut")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdAut"));

                    b.Property<string>("Nom")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdAut");

                    b.ToTable("Auteurs");
                });

            modelBuilder.Entity("LibraryBook.Models.Livre", b =>
                {
                    b.Property<int>("IdLivre")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdLivre"));

                    b.Property<int>("AnnéePub")
                        .HasColumnType("int");

                    b.Property<DateTime>("CreatedAt")
                        .HasColumnType("datetime2");

                    b.Property<string>("FilePath")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdAut")
                        .HasColumnType("int");

                    b.Property<int>("IdTheme")
                        .HasColumnType("int");

                    b.Property<string>("Titre")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("UpdatedAt")
                        .HasColumnType("datetime2");

                    b.HasKey("IdLivre");

                    b.HasIndex("IdAut");

                    b.HasIndex("IdTheme");

                    b.ToTable("Livres");
                });

            modelBuilder.Entity("LibraryBook.Models.Section", b =>
                {
                    b.Property<int>("IdSection")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdSection"));

                    b.Property<string>("FilePath")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("IdLivre")
                        .HasColumnType("int");

                    b.Property<string>("RowContent")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Titre")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdSection");

                    b.HasIndex("IdLivre");

                    b.ToTable("Sections");
                });

            modelBuilder.Entity("LibraryBook.Models.Theme", b =>
                {
                    b.Property<int>("IdTheme")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("IdTheme"));

                    b.Property<string>("Libelle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdTheme");

                    b.ToTable("Themes");
                });

            modelBuilder.Entity("LibraryBook.Models.Livre", b =>
                {
                    b.HasOne("LibraryBook.Models.Auteur", "Auteur")
                        .WithMany("Livres")
                        .HasForeignKey("IdAut")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("LibraryBook.Models.Theme", "Theme")
                        .WithMany("Livres")
                        .HasForeignKey("IdTheme")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Auteur");

                    b.Navigation("Theme");
                });

            modelBuilder.Entity("LibraryBook.Models.Section", b =>
                {
                    b.HasOne("LibraryBook.Models.Livre", "Livre")
                        .WithMany("Sections")
                        .HasForeignKey("IdLivre")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Livre");
                });

            modelBuilder.Entity("LibraryBook.Models.Auteur", b =>
                {
                    b.Navigation("Livres");
                });

            modelBuilder.Entity("LibraryBook.Models.Livre", b =>
                {
                    b.Navigation("Sections");
                });

            modelBuilder.Entity("LibraryBook.Models.Theme", b =>
                {
                    b.Navigation("Livres");
                });
#pragma warning restore 612, 618
        }
    }
}