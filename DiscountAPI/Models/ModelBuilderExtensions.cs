using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed( this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product { Id = 1, Name = "Cold Ice Tea", Description = "Cold Ice Tea", Price = 10, CategoryId = 1 },
                new Product { Id = 2, Name = "Coffee flavoured milk", Description = "Coffee flavoured milk", Price = 12, CategoryId = 1 },
                new Product { Id = 3, Name = "Nuke-Cola", Description = "Nuke-Cola", Price = 14, CategoryId = 1 },
                new Product { Id = 4, Name = "Sprute", Description = "Sprute", Price = 16, CategoryId = 1 },
                new Product { Id = 5, Name = "Slurm", Description = "Slurm", Price = 18, CategoryId = 1 },
                new Product { Id = 6, Name = "Diet Slurm", Description = "Diet Slurm", Price = 20, CategoryId = 1 },
                new Product { Id = 7, Name = "Atlantis detergent", Description = "Atlantis detergent", Price = 22, CategoryId = 2 },
                new Product { Id = 8, Name = "Virulanita", Description = "Virulanita", Price = 24, CategoryId = 2 },
                new Product { Id = 9, Name = "Sponge, Bob", Description = "Sponge, Bob", Price = 26, CategoryId = 2 },
                new Product { Id = 10, Name = "Generic mop", Description = "Generic mop", Price = 28, CategoryId = 2 },
                new Product { Id = 11, Name = "Salsa Cookies", Description = "Salsa Cookies", Price = 30, CategoryId = 3 },
                new Product { Id = 12, Name = "Windmill Cookies", Description = "Windmill Cookies", Price = 32, CategoryId = 3 },
                new Product { Id = 13, Name = "Garlic-o-bread 2000", Description = "Garlic-o-bread 2000", Price = 34, CategoryId = 3 },
                new Product { Id = 14, Name = "LACTEL bread", Description = "LACTEL bread", Price = 36, CategoryId = 3 },
                new Product { Id = 15, Name = "Ravioloches x12", Description = "Ravioloches x12", Price = 38, CategoryId = 3 },
                new Product { Id = 16, Name = "Ravioloches x48", Description = "Ravioloches x48", Price = 40, CategoryId = 3 },
                new Product { Id = 17, Name = "Milanga ganga", Description = "Milanga ganga", Price = 42, CategoryId = 3 },
                new Product { Id = 18, Name = "Milanga ganga napo", Description = "Milanga ganga napo", Price = 44, CategoryId = 3 },
                new Product { Id = 19, Name = "Pure steel toilet paper", Description = "Pure steel toilet paper", Price = 46, CategoryId = 4 },
                new Product { Id = 20, Name = "Generic soap", Description = "Generic soap", Price = 48, CategoryId = 4 },
                new Product { Id = 21, Name = "PANTONE shampoo", Description = "PANTONE shampoo", Price = 50, CategoryId = 4 },
                new Product { Id = 22, Name = "Cabbagegate toothpaste", Description = "Cabbagegate toothpaste", Price = 52, CategoryId = 4 }
            );//Product

            modelBuilder.Entity<Category>().HasData(
                    new Category { Id = 1, Nombre = "Sodas" },
                    new Category { Id = 2, Nombre = "Cleaning" },
                    new Category { Id = 3, Nombre = "Food" },
                    new Category { Id = 4, Nombre = "Bathroom" }
                );

            modelBuilder.Entity<Store>().HasData(
                new Store { Id = 1, Name = "COCO Downtown", OpenTime = 9, CloseTime = 22 },
                new Store { Id = 2, Name = "COCO Bay", OpenTime = 9, CloseTime = 22 },
                new Store { Id = 3, Name = "COCO Mall", OpenTime = 9, CloseTime = 22 }
                );

            modelBuilder.Entity<Stock>().HasData(
                new Stock { StoreStockId = 1, ProductStockId=1,  Quantity=10 },
                new Stock { StoreStockId = 1, ProductStockId = 2, Quantity = 20 },
                new Stock { StoreStockId = 1, ProductStockId = 3, Quantity = 10 },
                new Stock { StoreStockId = 1, ProductStockId = 4, Quantity = 12 },
                new Stock { StoreStockId = 2, ProductStockId = 10, Quantity = 30 },
                new Stock { StoreStockId = 2, ProductStockId = 18, Quantity = 5 },
                new Stock { StoreStockId = 2, ProductStockId = 13, Quantity = 30 },
                new Stock { StoreStockId = 2, ProductStockId = 22, Quantity = 5 },
                new Stock { StoreStockId = 3, ProductStockId = 5, Quantity = 11 },
                new Stock { StoreStockId = 3, ProductStockId = 6, Quantity = 15 },
                new Stock { StoreStockId = 3, ProductStockId = 3, Quantity = 10 },
                new Stock { StoreStockId = 3, ProductStockId = 8, Quantity = 12 },
                new Stock { StoreStockId = 3, ProductStockId = 4, Quantity = 9 }
                );
        }
    }
}
