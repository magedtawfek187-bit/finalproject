using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using final_project.Data;

namespace final_project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class ReviewsController : Controller
    {
        private readonly ApplicationDbContext _context;
        public ReviewsController(ApplicationDbContext context) => _context = context;

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Reviews";
            var reviews = await _context.Reviews
                .Include(r => r.Customer)
                .Include(r => r.Restaurant)
                .OrderByDescending(r => r.ReviewDate)
                .ToListAsync();
            return View(reviews);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var review = await _context.Reviews.FindAsync(id);
            if (review == null) return NotFound();
            _context.Reviews.Remove(review);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Review Deleted Succesfully";
            return RedirectToAction(nameof(Index));
        }
    }
}
