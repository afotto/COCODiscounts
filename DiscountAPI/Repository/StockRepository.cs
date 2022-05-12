using DiscountAPI.Context;
using DiscountAPI.Models;
using DiscountAPI.Repository.IRepository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace DiscountAPI.Repository
{
    public class StockRepository : IStockRepository
    {
        private readonly ApplicationDbContext context;
        public StockRepository(ApplicationDbContext context)
        {
            this.context = context;
        }
        public bool CreateStock(Stock stock)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Stock> GetAllStock()
        {
            return context.Stock
                .Include(s => s.StoreStock)
                .Include(p => p.ProductStock)
                .ToList();
        }

        public Stock GetStock(int idStore, int idProduct)
        {
            throw new NotImplementedException();
        }

        public bool Save()
        {
            throw new NotImplementedException();
        }

        public bool UpdateStock(Stock stock)
        {
            throw new NotImplementedException();
        }
    }
}
