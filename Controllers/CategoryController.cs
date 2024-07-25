using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCECommerce.Data;

namespace MVCECommerce.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ApplicationDbContext _context;
        public CategoryController(ApplicationDbContext context)
        {
            _context = context;
        }
        public IActionResult Index(int id_category)
        {
            var articles = _context.Article.Include(c => c.Variant.OrderByDescending(v => v.Priority)).ThenInclude(c => c.Color).Where(c => c.CategoryId == id_category).ToList();
            return View(articles);
        }
    }
}
