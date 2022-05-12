using System.ComponentModel.DataAnnotations;

namespace DiscountAPI.Models.DTO
{
    public class CategoryDTO
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="The name is required")]
        public string Nombre { get; set; }
    }
}
