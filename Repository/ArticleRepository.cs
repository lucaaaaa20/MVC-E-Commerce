using Microsoft.EntityFrameworkCore;
using MVCECommerce.Data;
using MVCECommerce.Interfaces;
using MVCECommerce.Models;

namespace MVCECommerce.Repository
{
    public class ArticleRepository : IArticleRepository
    {
        private readonly ApplicationDbContext _context;
        public ArticleRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Article>> GetAll()
        {
            return await _context.Article.ToListAsync();
        }
    }
}
