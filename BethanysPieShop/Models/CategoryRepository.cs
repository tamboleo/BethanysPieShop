namespace BethanysPieShop.Models
{
    public class CategoryRepository : ICategoryReporsitory
    {
        private readonly BethanysPieShopDbContext _context;
        public CategoryRepository(BethanysPieShopDbContext context)
        {
              _context = context;
        }
        public IEnumerable<Category> AllCategories => _context.Categories.OrderBy(p => p.CategoryName);
    }
}
