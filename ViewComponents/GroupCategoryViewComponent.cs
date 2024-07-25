using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVCECommerce.Data;

namespace MVCECommerce.ViewComponents
{
    public class GroupCategoryViewComponent : ViewComponent
    {
        private readonly ApplicationDbContext _context;
        public GroupCategoryViewComponent(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var groups = await _context.Group.Include(g => g.Category).ToListAsync();
            return View(groups);
        }
    }
}