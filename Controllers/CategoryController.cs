using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Data;
using Microsoft.EntityFrameworkCore;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers
{
    public class CategoryController : Controller
    {
        private readonly AppDbContext _db;
        public CategoryController(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            var categoryList = _db.Categories.ToList();
            return View(categoryList);
        }

        public IActionResult Details(int id)
        {
            var categoryDetail = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == id);
            if (categoryDetail == null) return NotFound();
            return View(categoryDetail);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Category newCategory)
        {
            if (!ModelState.IsValid) return View(newCategory);
            _db.Categories.Add(newCategory);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Edit(int id)
        {
            var editCategory = _db.Categories.Find(id);
            if (editCategory == null) return NotFound();
            return View(editCategory);
        }

        [HttpPost]
        public IActionResult Edit(Category updateCategory)
        {
            if (!ModelState.IsValid) return View(updateCategory);
            _db.Categories.Update(updateCategory);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            var deleteCategory = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == id);
            if (deleteCategory == null) return NotFound();
            return View(deleteCategory);
        }

        [HttpPost, ActionName("Delete")]
        public IActionResult DeleteConfirmed(int id)
        {
            var deleteCategory = _db.Categories.Include(c => c.Products).FirstOrDefault(c => c.Id == id);
            if (deleteCategory == null) return NotFound();       
            _db.Categories.Remove(deleteCategory);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }    
    }
}
