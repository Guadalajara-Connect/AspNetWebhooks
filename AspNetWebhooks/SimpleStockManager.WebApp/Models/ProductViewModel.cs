using System.ComponentModel.DataAnnotations;

namespace SimpleSalesOrder.WebApp.Models
{
    public class ProductViewModel
    {
        public string Id { get; set; }

        [Required]
        [StringLength(25, ErrorMessage = "Product's name has exceeded its maximum lenght.")]
        public string Name { get; set; }

        [Required]
        public double Price { get; set; }

        [Required]
        public double Quantity { get; set; }
    }
}