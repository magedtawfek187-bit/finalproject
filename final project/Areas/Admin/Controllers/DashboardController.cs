using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using final_project.Data;
using final_project.Models;
using final_project.Areas.Admin.ViewModels;

namespace final_project.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DashboardController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;

        public DashboardController(ApplicationDbContext context, UserManager<ApplicationUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }

        public async Task<IActionResult> Index()
        {
            var vm = new DashboardViewModel();

            
            vm.TotalUsers = await _userManager.Users.CountAsync();
            vm.TotalRestaurants = await _context.Restaurants.CountAsync();
            vm.TotalProducts = await _context.Products.CountAsync();
            vm.TotalOrders = await _context.Orders.CountAsync();
            vm.TotalDrivers = await _context.Drivers.CountAsync();
            vm.TotalDeliveries = await _context.Deliveries.CountAsync();
            vm.TotalReviews = await _context.Reviews.CountAsync();
            vm.TotalRevenue = await _context.Orders
                .Where(o => o.Status == OrderStatus.Delivered)
                .SumAsync(o => o.TotalAmount);

            
            vm.PendingOrders = await _context.Orders.CountAsync(o => o.Status == OrderStatus.Pending);
            vm.PreparingOrders = await _context.Orders.CountAsync(o => o.Status == OrderStatus.Preparing);
            vm.OnTheWayOrders = await _context.Orders.CountAsync(o => o.Status == OrderStatus.OnTheWay);
            vm.DeliveredOrders = await _context.Orders.CountAsync(o => o.Status == OrderStatus.Delivered);
            vm.CancelledOrders = await _context.Orders.CountAsync(o => o.Status == OrderStatus.Cancelled);

            
            var topRestaurants = await _context.Orders
                .Include(o => o.OrderItems)
                    .ThenInclude(oi => oi.Product)
                        .ThenInclude(p => p.Restaurant)
                .SelectMany(o => o.OrderItems)
                .GroupBy(oi => oi.Product.Restaurant.Name)
                .Select(g => new { Name = g.Key, Count = g.Count() })
                .OrderByDescending(x => x.Count)
                .Take(5)
                .ToListAsync();

            vm.TopRestaurantNames = topRestaurants.Select(r => r.Name).ToList();
            vm.TopRestaurantOrders = topRestaurants.Select(r => r.Count).ToList();

           
            for (int i = 6; i >= 0; i--)
            {
                var day = DateTime.Today.AddDays(-i);
                vm.LastWeekDays.Add(day.ToString("dd/MM"));
                vm.LastWeekOrders.Add(await _context.Orders
                    .CountAsync(o => o.OrderDate.Date == day));
            }

            ViewData["Title"] = "Control Panel";
            return View(vm);
        }
    }
}
