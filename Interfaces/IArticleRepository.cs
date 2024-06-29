using MVCECommerce.Models;

namespace MVCECommerce.Interfaces
{
    public interface IArticleRepository
    {
        Task<IEnumerable<Article>> GetAll();
    }
}
