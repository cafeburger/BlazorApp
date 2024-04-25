﻿// <auto-generated />
using System;
using BlazorApp.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BlazorApp.Migrations
{
    [DbContext(typeof(BlazorAppContext))]
    [Migration("20240425143307_InitialCreate")]
    partial class InitialCreate
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            MySqlModelBuilderExtensions.AutoIncrementColumns(modelBuilder);

            modelBuilder.Entity("BlazorApp.Data.Entities.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    MySqlPropertyBuilderExtensions.UseMySqlIdentityColumn(b.Property<int>("ProductId"));

                    b.Property<DateTime>("CreatedDate")
                        .HasColumnType("datetime(6)");

                    b.Property<string>("Description")
                        .HasMaxLength(500)
                        .HasColumnType("varchar(500)");

                    b.Property<bool>("IsActive")
                        .HasColumnType("tinyint(1)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("varchar(100)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18, 2)");

                    b.Property<int>("Stock")
                        .HasColumnType("int");

                    b.Property<DateTime>("UpdatedDate")
                        .HasColumnType("datetime(6)");

                    b.HasKey("ProductId");

                    b.ToTable("Products");

                    b.HasData(
                        new
                        {
                            ProductId = 1,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4014),
                            Description = "14-inch MacBook Pro with M1 Pro chip.",
                            IsActive = true,
                            Name = "Apple MacBook Pro 14",
                            Price = 1999.00m,
                            Stock = 10,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4015)
                        },
                        new
                        {
                            ProductId = 2,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4017),
                            Description = "16-inch MacBook Pro with M1 Max chip.",
                            IsActive = true,
                            Name = "Apple MacBook Pro 16",
                            Price = 2499.00m,
                            Stock = 8,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4017)
                        },
                        new
                        {
                            ProductId = 3,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4020),
                            Description = "13.3-inch ultra-portable laptop from Dell.",
                            IsActive = true,
                            Name = "Dell XPS 13",
                            Price = 999.00m,
                            Stock = 15,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4020)
                        },
                        new
                        {
                            ProductId = 4,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4023),
                            Description = "15-inch powerful laptop ideal for professionals.",
                            IsActive = true,
                            Name = "Dell XPS 15",
                            Price = 1300.00m,
                            Stock = 6,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4023)
                        },
                        new
                        {
                            ProductId = 5,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4025),
                            Description = "Latest Samsung flagship smartphone with triple camera system.",
                            IsActive = true,
                            Name = "Samsung Galaxy S21",
                            Price = 799.00m,
                            Stock = 20,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4026)
                        },
                        new
                        {
                            ProductId = 6,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4029),
                            Description = "Newest Pixel phone with Google's own Tensor chip.",
                            IsActive = true,
                            Name = "Google Pixel 6",
                            Price = 599.00m,
                            Stock = 25,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4029)
                        },
                        new
                        {
                            ProductId = 7,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4032),
                            Description = "Latest generation console from Sony.",
                            IsActive = true,
                            Name = "Sony PlayStation 5",
                            Price = 499.99m,
                            Stock = 30,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4032)
                        },
                        new
                        {
                            ProductId = 8,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4034),
                            Description = "Most powerful Xbox with 12 teraflops of processing power.",
                            IsActive = true,
                            Name = "Microsoft Xbox Series X",
                            Price = 499.99m,
                            Stock = 20,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4035)
                        },
                        new
                        {
                            ProductId = 9,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4037),
                            Description = "Popular hybrid gaming console from Nintendo.",
                            IsActive = true,
                            Name = "Nintendo Switch",
                            Price = 299.99m,
                            Stock = 35,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4038)
                        },
                        new
                        {
                            ProductId = 10,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4040),
                            Description = "The latest iPhone with advanced dual-camera system.",
                            IsActive = true,
                            Name = "Apple iPhone 13",
                            Price = 799.00m,
                            Stock = 25,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4040)
                        },
                        new
                        {
                            ProductId = 11,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4043),
                            Description = "High-end smartphone with superior camera capabilities.",
                            IsActive = true,
                            Name = "Huawei P50 Pro",
                            Price = 899.00m,
                            Stock = 10,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4043)
                        },
                        new
                        {
                            ProductId = 12,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4045),
                            Description = "Powerful iPad with M1 chip and 12.9-inch display.",
                            IsActive = true,
                            Name = "Apple iPad Pro",
                            Price = 1099.00m,
                            Stock = 12,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4046)
                        },
                        new
                        {
                            ProductId = 13,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4048),
                            Description = "High-performance tablet with S Pen included.",
                            IsActive = true,
                            Name = "Samsung Galaxy Tab S7",
                            Price = 649.99m,
                            Stock = 18,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4048)
                        },
                        new
                        {
                            ProductId = 14,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4051),
                            Description = "Versatile laptop-tablet hybrid with Windows 10.",
                            IsActive = true,
                            Name = "Microsoft Surface Pro 7",
                            Price = 899.99m,
                            Stock = 14,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4051)
                        },
                        new
                        {
                            ProductId = 15,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4053),
                            Description = "Gaming smartphone with optimized hardware for gaming.",
                            IsActive = true,
                            Name = "Asus ROG Phone 5",
                            Price = 699.99m,
                            Stock = 10,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4054)
                        },
                        new
                        {
                            ProductId = 16,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4056),
                            Description = "Advanced wireless mouse designed for precision and control.",
                            IsActive = true,
                            Name = "Logitech MX Master 3",
                            Price = 99.99m,
                            Stock = 40,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4056)
                        },
                        new
                        {
                            ProductId = 17,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4058),
                            Description = "Industry-leading noise cancelling headphones.",
                            IsActive = true,
                            Name = "Sony WH-1000XM4",
                            Price = 349.99m,
                            Stock = 22,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4059)
                        },
                        new
                        {
                            ProductId = 18,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4061),
                            Description = "Noise cancelling earbuds from Bose.",
                            IsActive = true,
                            Name = "Bose QuietComfort Earbuds",
                            Price = 279.00m,
                            Stock = 30,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4062)
                        },
                        new
                        {
                            ProductId = 19,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4064),
                            Description = "Latest smartwatch from Apple with ECG app.",
                            IsActive = true,
                            Name = "Apple Watch Series 7",
                            Price = 399.00m,
                            Stock = 18,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4064)
                        },
                        new
                        {
                            ProductId = 20,
                            CreatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4066),
                            Description = "Advanced fitness tracker with built-in GPS and heart rate monitoring.",
                            IsActive = true,
                            Name = "Fitbit Charge 5",
                            Price = 179.99m,
                            Stock = 25,
                            UpdatedDate = new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4067)
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
