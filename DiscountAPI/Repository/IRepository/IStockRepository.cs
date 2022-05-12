using DiscountAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountAPI.Repository.IRepository
{
    public interface IStockRepository
    {
        IEnumerable<Stock> GetAllStock();
        Stock GetStock(int idStore, int idProduct);
        bool CreateStock(Stock stock);
        bool UpdateStock(Stock stock);
        bool Save();
    }
}
