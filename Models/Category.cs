using System.ComponentModel.DataAnnotations;

namespace ProductCatalog.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        public required string CategoryName { get; set; }
        public ICollection<Product> Products { get; set; } = new List<Product>();

        public Category()
        {

        }
    }
 }
