using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using final_project.Data;
using final_project.Models;

namespace final_project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DriversController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DriversController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            ViewData["Title"] = "Drivers";
            var drivers = await _context.Drivers.Include(d => d.User).ToListAsync();
            return View(drivers);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            ViewData["Title"] = "Add Drivers";
            await LoadUsers();
            return View();
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Driver model)
        {
            if (!ModelState.IsValid) { await LoadUsers(); return View(model); }
            _context.Drivers.Add(model);
            await _context.SaveChangesAsync();

            // إضافة Role Driver للـ User
            var user = await _userManager.FindByIdAsync(model.UserID);
            if (user != null && !await _userManager.IsInRoleAsync(user, "Driver"))
                await _userManager.AddToRoleAsync(user, "Driver");

            TempData["Success"] = "Driver Added Succesfully";
            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null) return NotFound();
            ViewData["Title"] = "Edit Driver";
            await LoadUsers(driver.UserID);
            return View(driver);
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Driver model)
        {
            if (!ModelState.IsValid) { await LoadUsers(); return View(model); }
            _context.Drivers.Update(model);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Driver Added Succefully";
            return RedirectToAction(nameof(Index));
        }

        [HttpPost, ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var driver = await _context.Drivers.FindAsync(id);
            if (driver == null) return NotFound();
            _context.Drivers.Remove(driver);
            await _context.SaveChangesAsync();
            TempData["Success"] = "Driver Deleted Succesfully";
            return RedirectToAction(nameof(Index));
        }

        private async Task LoadUsers(string selectedId = null)
        {
            var users = await _userManager.Users.ToListAsync();
            ViewBag.Users = new SelectList(users, "Id", "FullName", selectedId);
        }
    }
}
