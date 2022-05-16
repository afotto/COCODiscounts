using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text.Json.Serialization;

namespace DiscountAPI.Models
{
    public class ItemsVoucher
    {
        [Key]
        public int Id { get; set; }
        public string Item { get; set; }
        [ForeignKey("Voucher")]
        public string TitleVoucher { get; set; }
        [JsonIgnore]
        public Voucher Voucher { get; set; }


    }
}