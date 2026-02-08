using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Data;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ProductCatalog.Controllers
{
    public class ProductController : Controller
    {
        private readonly AppDbContext _db;
        public ProductController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var productList = _db.Products.Include(p => p.Category).ToList();
            return View(productList);
        }

        public IActionResult Details(int id)
        {
            var productDetail = _db.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            if (productDetail == null) return NotFound();
            return View(productDetail);
        }

        public IActionResult Create()
        {
            ViewBag.Categories = new SelectList(_db.Categories, "Id", "CategoryName");
            return View();
        }

        [HttpPost]
        public IActionResult Create(Product newProduct)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_db.Categories, "Id", "CategoryName");
                return View(newProduct);
            }
            _db.Products.Add(newProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var editProduct = _db.Products.Find(id);
            if (editProduct == null) return NotFound();
            ViewBag.Categories = new SelectList(_db.Categories, "Id", "CategoryName", editProduct.CategoryId);
            return View(editProduct);
        }

        [HttpPost]
        public IActionResult Edit(Product updateProduct)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Categories = new SelectList(_db.Categories, "Id", "CategoryName", updateProduct.CategoryId);
                return View(updateProduct);
            }
            _db.Products.Update(updateProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleteProduct = _db.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            if (deleteProduct == null) return NotFound();
            return View(deleteProduct);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deleteProduct = _db.Products.Include(p => p.Category).FirstOrDefault(p => p.Id == id);
            if (deleteProduct == null) return NotFound();
            _db.Products.Remove(deleteProduct);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
