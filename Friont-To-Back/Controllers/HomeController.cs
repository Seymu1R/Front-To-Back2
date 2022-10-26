using Friont_To_Back.Dal;
using Friont_To_Back.Models;
using Friont_To_Back.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace Friont_To_Back.Controllers
{
    public class HomeController : Controller
    {
        private AppDbContext _context;
      

        public HomeController(AppDbContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            List<Category> categories = await _context.Categories.Include(pro => pro.Products).ToListAsync();
             var boards = await _context.Boards.ToListAsync();
             HomeViewModel viewModel = new HomeViewModel() {
                Categories = categories,
                Boards = boards
            };
            return View(viewModel);
        }
        public async Task<IActionResult> Shop()
        {
            List<Category> categories = await _context.Categories.Include(pro => pro.Products).ToListAsync();
            return View(categories);
        }
    }
}
