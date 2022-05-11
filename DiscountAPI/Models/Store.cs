using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DiscountAPI.Models
{
    public class Store
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int OpenTime { get; set; }
        public int CloseTime { get; set; }


    }
}
