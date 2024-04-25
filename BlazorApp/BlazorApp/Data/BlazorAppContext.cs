using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using BlazorApp.Data.Entities;

namespace BlazorApp.Data
{
    public class BlazorAppContext : DbContext
    {
        public BlazorAppContext (DbContextOptions<BlazorAppContext> options)
            : base(options)
        {
        }

        public DbSet<Product> Product { get; set; } = default!;
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Product>().HasData(
                new Product { ProductId = 1, Name = "Apple MacBook Pro 14", Description = "14-inch MacBook Pro with M1 Pro chip.", Price = 1999.00m, Stock = 10, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 2, Name = "Apple MacBook Pro 16", Description = "16-inch MacBook Pro with M1 Max chip.", Price = 2499.00m, Stock = 8, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 3, Name = "Dell XPS 13", Description = "13.3-inch ultra-portable laptop from Dell.", Price = 999.00m, Stock = 15, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 4, Name = "Dell XPS 15", Description = "15-inch powerful laptop ideal for professionals.", Price = 1300.00m, Stock = 6, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 5, Name = "Samsung Galaxy S21", Description = "Latest Samsung flagship smartphone with triple camera system.", Price = 799.00m, Stock = 20, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 6, Name = "Google Pixel 6", Description = "Newest Pixel phone with Google's own Tensor chip.", Price = 599.00m, Stock = 25, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 7, Name = "Sony PlayStation 5", Description = "Latest generation console from Sony.", Price = 499.99m, Stock = 30, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 8, Name = "Microsoft Xbox Series X", Description = "Most powerful Xbox with 12 teraflops of processing power.", Price = 499.99m, Stock = 20, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 9, Name = "Nintendo Switch", Description = "Popular hybrid gaming console from Nintendo.", Price = 299.99m, Stock = 35, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 10, Name = "Apple iPhone 13", Description = "The latest iPhone with advanced dual-camera system.", Price = 799.00m, Stock = 25, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 11, Name = "Huawei P50 Pro", Description = "High-end smartphone with superior camera capabilities.", Price = 899.00m, Stock = 10, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 12, Name = "Apple iPad Pro", Description = "Powerful iPad with M1 chip and 12.9-inch display.", Price = 1099.00m, Stock = 12, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 13, Name = "Samsung Galaxy Tab S7", Description = "High-performance tablet with S Pen included.", Price = 649.99m, Stock = 18, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 14, Name = "Microsoft Surface Pro 7", Description = "Versatile laptop-tablet hybrid with Windows 10.", Price = 899.99m, Stock = 14, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 15, Name = "Asus ROG Phone 5", Description = "Gaming smartphone with optimized hardware for gaming.", Price = 699.99m, Stock = 10, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 16, Name = "Logitech MX Master 3", Description = "Advanced wireless mouse designed for precision and control.", Price = 99.99m, Stock = 40, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 17, Name = "Sony WH-1000XM4", Description = "Industry-leading noise cancelling headphones.", Price = 349.99m, Stock = 22, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 18, Name = "Bose QuietComfort Earbuds", Description = "Noise cancelling earbuds from Bose.", Price = 279.00m, Stock = 30, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 19, Name = "Apple Watch Series 7", Description = "Latest smartwatch from Apple with ECG app.", Price = 399.00m, Stock = 18, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow },
                new Product { ProductId = 20, Name = "Fitbit Charge 5", Description = "Advanced fitness tracker with built-in GPS and heart rate monitoring.", Price = 179.99m, Stock = 25, IsActive = true, CreatedDate = DateTime.UtcNow, UpdatedDate = DateTime.UtcNow }
            );
        }
    }
}
