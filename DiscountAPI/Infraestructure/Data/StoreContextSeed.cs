using DiscountAPI.Context;
using DiscountAPI.Models;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;

namespace DiscountAPI.Infraestructure.Data
{
    public class StoreContextSeed
    {
        private readonly ApplicationDbContext _context;
        public StoreContextSeed(ApplicationDbContext context)
        {
            _context = context;
        }

        public string Seed()
        {
            try
            {
                /*if (!_context.Store.Any())
                {
                    var storesData = File.ReadAllText("./Infraestructure/SeedData/Store.json");
                    var stores = JsonSerializer.Deserialize<List<Store>>(storesData);
                    foreach (var s in stores)
                    {
                        _context.Store.Add(s);
                    }
                    _context.SaveChanges();
                }
                if (!_context.Category.Any())
                {
                    var categoryData = File.ReadAllText("./Infraestructure/SeedData/Category.json");
                    var category = JsonSerializer.Deserialize<List<Category>>( categoryData );
                    foreach (var c in category)
                    {
                        _context.Category.Add(c);
                    }
                    _context.SaveChanges();
                }*/
                if (!_context.Product.Any())
                {
                    var productData = File.ReadAllText("./Infraestructure/SeedData/Products.json");
                    var product = JsonSerializer.Deserialize<List<Product>>(productData);
                    foreach (var p in product)
                    {
                        _context.Product.Add(p);
                    }
                    _context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                //var logger = loggerFactory.CreateLogger<StoreContextSeed>();
                //logger.LogError(ex.Message);
                //return ex.Message;
                string errorMessages = ex.InnerException.InnerException.ToString();
                return errorMessages;
                
            }

            return "Ok";
        }
    }
}
