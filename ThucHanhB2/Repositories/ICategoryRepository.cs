using ThucHanhB2.Models;

namespace ThucHanhB2.Repositories
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAllCategories();
    }
}
