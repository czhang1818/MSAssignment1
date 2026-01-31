using ProductCatalog.Models;

namespace ProductCatalog.Services
{
    public class ProductBL
    {
        public static List<Product> Products =
        [
            new Product {Id = 1, ProductName = "iPhone", ProductPrice = 999.99m, ImageUrl = "/images/iphone.jpg", Description = "Latest model smartphone with advanced camera system, A-series chip, and long battery life."},
            new Product {Id = 2, ProductName = "AirPods", ProductPrice = 199.99m, ImageUrl = "/images/airpods.jpg", Description = "Wireless earbuds with active noise cancellation, spatial audio, and quick device pairing."},
            new Product {Id = 3, ProductName = "iPad", ProductPrice = 499.99m, ImageUrl = "/images/ipad.jpg", Description = "Versatile tablet for productivity and media with a high-resolution display and long battery life."},
            new Product {Id = 4, ProductName = "MacBook Pro", ProductPrice = 1299.99m, ImageUrl = "/images/macbookpro.jpg", Description = "Powerful laptop with M1 chip, Retina display, and all-day battery life for professionals." },
            new Product {Id = 5, ProductName = "Apple Watch", ProductPrice = 399.99m, ImageUrl = "/images/applewatch.jpg", Description = "Smartwatch with fitness tracking, heart rate monitoring, and seamless integration with iPhone." }
        ];

        public static List<Product> GetAllProduct()
        {
            return Products;
        }

        public static Product GetProductById(int id)
        {
            return Products.FirstOrDefault(p => p.Id == id);
        }
    }
}
