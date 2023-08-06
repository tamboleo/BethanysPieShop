namespace BethanysPieShop.Models
{
    public interface ICategoryReporsitory
    {
        IEnumerable<Category> AllCategories { get; }
    }
}
