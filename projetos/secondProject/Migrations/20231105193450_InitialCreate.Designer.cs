﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using secondProject.Models;

#nullable disable

namespace secondProject.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231105193450_InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.1")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("secondProject.Models.Books", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("CatalogId")
                        .HasColumnType("int");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("NumberOfBook")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("CatalogId");

                    b.ToTable("Books");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Books");
                });

            modelBuilder.Entity("secondProject.Models.Catalog", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("AuthorName")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Catalog");
                });

            modelBuilder.Entity("secondProject.Models.Librarian", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Librarian");
                });

            modelBuilder.Entity("secondProject.Models.Member", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Discriminator")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<int>("MobileNumber")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasKey("Id");

                    b.ToTable("Member");

                    b.HasDiscriminator<string>("Discriminator").HasValue("Member");
                });

            modelBuilder.Entity("secondProject.Models.FacultyMember", b =>
                {
                    b.HasBaseType("secondProject.Models.Member");

                    b.Property<string>("FacultyColl")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.Property<string>("Fname")
                        .IsRequired()
                        .HasColumnType("longtext");

                    b.HasDiscriminator().HasValue("FacultyMember");
                });

            modelBuilder.Entity("secondProject.Models.GeneralBook", b =>
                {
                    b.HasBaseType("secondProject.Models.Books");

                    b.HasDiscriminator().HasValue("GeneralBook");
                });

            modelBuilder.Entity("secondProject.Models.ReferenceBook", b =>
                {
                    b.HasBaseType("secondProject.Models.Books");

                    b.HasDiscriminator().HasValue("ReferenceBook");
                });

            modelBuilder.Entity("secondProject.Models.Student", b =>
                {
                    b.HasBaseType("secondProject.Models.Member");

                    b.HasDiscriminator().HasValue("Student");
                });

            modelBuilder.Entity("secondProject.Models.Books", b =>
                {
                    b.HasOne("secondProject.Models.Catalog", "Catalog")
                        .WithMany()
                        .HasForeignKey("CatalogId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Catalog");
                });
#pragma warning restore 612, 618
        }
    }
}
