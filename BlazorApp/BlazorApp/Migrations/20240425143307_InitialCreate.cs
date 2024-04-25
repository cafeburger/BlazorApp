using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BlazorApp.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterDatabase()
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.CreateTable(
                name: "Products",
                columns: table => new
                {
                    ProductId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("MySql:ValueGenerationStrategy", MySqlValueGenerationStrategy.IdentityColumn),
                    Name = table.Column<string>(type: "varchar(100)", maxLength: 100, nullable: false)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Description = table.Column<string>(type: "varchar(500)", maxLength: 500, nullable: true)
                        .Annotation("MySql:CharSet", "utf8mb4"),
                    Price = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Stock = table.Column<int>(type: "int", nullable: false),
                    IsActive = table.Column<bool>(type: "tinyint(1)", nullable: false),
                    CreatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false),
                    UpdatedDate = table.Column<DateTime>(type: "datetime(6)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Products", x => x.ProductId);
                })
                .Annotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "CreatedDate", "Description", "IsActive", "Name", "Price", "Stock", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4014), "14-inch MacBook Pro with M1 Pro chip.", true, "Apple MacBook Pro 14", 1999.00m, 10, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4015) },
                    { 2, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4017), "16-inch MacBook Pro with M1 Max chip.", true, "Apple MacBook Pro 16", 2499.00m, 8, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4017) },
                    { 3, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4020), "13.3-inch ultra-portable laptop from Dell.", true, "Dell XPS 13", 999.00m, 15, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4020) },
                    { 4, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4023), "15-inch powerful laptop ideal for professionals.", true, "Dell XPS 15", 1300.00m, 6, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4023) },
                    { 5, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4025), "Latest Samsung flagship smartphone with triple camera system.", true, "Samsung Galaxy S21", 799.00m, 20, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4026) },
                    { 6, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4029), "Newest Pixel phone with Google's own Tensor chip.", true, "Google Pixel 6", 599.00m, 25, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4029) },
                    { 7, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4032), "Latest generation console from Sony.", true, "Sony PlayStation 5", 499.99m, 30, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4032) },
                    { 8, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4034), "Most powerful Xbox with 12 teraflops of processing power.", true, "Microsoft Xbox Series X", 499.99m, 20, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4035) },
                    { 9, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4037), "Popular hybrid gaming console from Nintendo.", true, "Nintendo Switch", 299.99m, 35, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4038) },
                    { 10, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4040), "The latest iPhone with advanced dual-camera system.", true, "Apple iPhone 13", 799.00m, 25, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4040) },
                    { 11, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4043), "High-end smartphone with superior camera capabilities.", true, "Huawei P50 Pro", 899.00m, 10, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4043) },
                    { 12, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4045), "Powerful iPad with M1 chip and 12.9-inch display.", true, "Apple iPad Pro", 1099.00m, 12, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4046) },
                    { 13, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4048), "High-performance tablet with S Pen included.", true, "Samsung Galaxy Tab S7", 649.99m, 18, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4048) },
                    { 14, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4051), "Versatile laptop-tablet hybrid with Windows 10.", true, "Microsoft Surface Pro 7", 899.99m, 14, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4051) },
                    { 15, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4053), "Gaming smartphone with optimized hardware for gaming.", true, "Asus ROG Phone 5", 699.99m, 10, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4054) },
                    { 16, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4056), "Advanced wireless mouse designed for precision and control.", true, "Logitech MX Master 3", 99.99m, 40, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4056) },
                    { 17, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4058), "Industry-leading noise cancelling headphones.", true, "Sony WH-1000XM4", 349.99m, 22, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4059) },
                    { 18, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4061), "Noise cancelling earbuds from Bose.", true, "Bose QuietComfort Earbuds", 279.00m, 30, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4062) },
                    { 19, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4064), "Latest smartwatch from Apple with ECG app.", true, "Apple Watch Series 7", 399.00m, 18, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4064) },
                    { 20, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4066), "Advanced fitness tracker with built-in GPS and heart rate monitoring.", true, "Fitbit Charge 5", 179.99m, 25, new DateTime(2024, 4, 25, 14, 33, 6, 703, DateTimeKind.Utc).AddTicks(4067) }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Products");
        }
    }
}
