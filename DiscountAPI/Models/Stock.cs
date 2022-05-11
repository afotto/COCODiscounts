using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountAPI.Models
{
    public class Stock
    {
        public Store StoreStock { get; set; }
        public int StoreStockId { get; set; }
        public Product ProductStock { get; set; }
        public int ProductStockId { get; set; }
        public int Quantity { get; set; }
    }
}
