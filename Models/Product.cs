using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; } = string.Empty;
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        [Required]
        public int CategoryId { get; set; }
        public Category? Category { get; set; }

        public Product()
        {
            
        }
    }
}
