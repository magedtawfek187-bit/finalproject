using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using final_project.Data;
using final_project.Models;

namespace final_project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ProductsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ProductsController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Products";
            var products = await _context.Products
                .Include(p => p.Restaurant)
                .Include(p => p.Category)
                .ToListAsync();
            return View(products);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewData["Title"] = "Add Product";
            await LoadDropdowns();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Product model)
        {
            if (!ModelState.IsValid) { await LoadDropdowns(); return View(model); }
            _context.Products.Add(model);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Product Added Succesfully";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            ViewData["Title"] = "Edite Product";
            await LoadDropdowns(product.RestaurantID, product.CategoryID);
            return View(product);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Product model)
        {
            if (!ModelState.IsValid) { await LoadDropdowns(); return View(model); }
            _context.Products.Update(model);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Product Edited Succesfully";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var product = await _context.Products.FindAsync(id);
            if (product == null) return NotFound();
            _context.Products.Remove(product);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Product Deleted Succesfully";
            return RedirectToAction(nameof(Index));
        }

        private async Task LoadDropdowns(int? restaurantId = null, int? categoryId = null)
        {
            ViewBag.Restaurants = new SelectList(await _context.Restaurants.ToListAsync(), "RestaurantID", "Name", restaurantId);
            ViewBag.Categories = new SelectList(await _context.Categories.ToListAsync(), "CategoryID", "Name", categoryId);
        }
    }
}
