﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using api.Server.Data;

#nullable disable

namespace api.Server.Migrations
{
    [DbContext(typeof(apiServerContext))]
    [Migration("20241127115038_create db & seed data")]
    partial class createdbseeddata
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.11")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("api.Server.Models.Book", b =>
                {
                    b.Property<int>("BookId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BookId"));

                    b.Property<string>("BookCover")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("BookPrice")
                        .HasColumnType("float");

                    b.Property<int>("BookQuantity")
                        .HasColumnType("int");

                    b.Property<string>("BookTitle")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BookId");

                    b.ToTable("Book");

                    b.HasData(
                        new
                        {
                            BookId = 1,
                            BookCover = "https://m.media-amazon.com/images/I/41jEbK-jG+L._SX258_BO1,204,203,200_.jpg",
                            BookPrice = 30.0,
                            BookQuantity = 15,
                            BookTitle = "Clean Code: A Handbook of Agile Software Craftsmanship"
                        },
                        new
                        {
                            BookId = 2,
                            BookCover = "https://m.media-amazon.com/images/I/41as+WafrFL._SX218_BO1,204,203,200_QL40_FMwebp_.jpg",
                            BookPrice = 35.0,
                            BookQuantity = 20,
                            BookTitle = "The Pragmatic Programmer: Your Journey To Mastery"
                        },
                        new
                        {
                            BookId = 3,
                            BookCover = "https://m.media-amazon.com/images/I/81kqrwS1nNL.jpg",
                            BookPrice = 20.0,
                            BookQuantity = 10,
                            BookTitle = "You Don’t Know JS Yet: Scope & Closures"
                        },
                        new
                        {
                            BookId = 4,
                            BookCover = "https://m.media-amazon.com/images/I/51k+lN0RWbL._SX218_BO1,204,203,200_QL40_FMwebp_.jpg",
                            BookPrice = 50.0,
                            BookQuantity = 5,
                            BookTitle = "Design Patterns: Elements of Reusable Object-Oriented Software"
                        },
                        new
                        {
                            BookId = 5,
                            BookCover = "https://m.media-amazon.com/images/I/41MN80OBcBL.jpg",
                            BookPrice = 75.0,
                            BookQuantity = 8,
                            BookTitle = "Introduction to Algorithms"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}