using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using final_project.Data;
using final_project.Models;

namespace final_project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class RestaurantsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public RestaurantsController(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Restaurents";
            return View(await _context.Restaurants.ToListAsync());
        }

        [HttpGet]
        public IActionResult Create()
        {
            ViewData["Title"] = "Add restaurent";
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Restaurant model)
        {
            if (!ModelState.IsValid) return View(model);
            _context.Restaurants.Add(model);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Restaurent added";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null) return NotFound();
            ViewData["Title"] = "Edit restaurent";
            return View(restaurant);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Restaurant model)
        {
            if (!ModelState.IsValid) return View(model);
            _context.Restaurants.Update(model);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Restaurent edited";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var restaurant = await _context.Restaurants.FindAsync(id);
            if (restaurant == null) return NotFound();
            _context.Restaurants.Remove(restaurant);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Restaurent Deleted";
            return RedirectToAction(nameof(Index));
        }
    }
}
