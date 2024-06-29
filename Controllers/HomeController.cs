using Microsoft.AspNetCore.Mvc;
using MVCECommerce.Data;
using MVCECommerce.Interfaces;
using MVCECommerce.Models;
using System.Diagnostics;

namespace MVCECommerce.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _context;
        private readonly IArticleRepository _articleRepository;
        public HomeController(ApplicationDbContext context, IArticleRepository articleRepository)
        {
            _context = context;
            _articleRepository = articleRepository;
        }

        public async Task<IActionResult> Index()
        {
            IEnumerable<Article> articles = await _articleRepository.GetAll();
            return View(articles);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
