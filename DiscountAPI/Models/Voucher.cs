using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountAPI.Models
{
    public class Voucher
    {
        [Key]
        public string Title { get; set; }
        [Required]
        public int IdStore { get; set; }
        public List<ItemsVoucher> ItemsVoucher { get; set; }


    }
}
