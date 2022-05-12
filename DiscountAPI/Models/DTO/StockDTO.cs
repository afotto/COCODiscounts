using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountAPI.Models.DTO
{
    public class StockDTO
    {
        [Required]
        public int StoreStockId { get; set; }
        public string nameStore { get; set; }
        [Required]
        public int ProductStockId { get; set; }
        public string nameProduct { get; set; }
        public int Quantity { get; set; }
    }
}
