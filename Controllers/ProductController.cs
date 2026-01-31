using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Services;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult ShowAll()
        {
            return View(ProductBL.GetAllProduct());
        }

        public IActionResult ShowById(int id)
        {
            var product = ProductBL.GetProductById(id);
            if (product == null)
            {
                return NotFound();
            }
            return View(product);
        }
    }
}
