﻿namespace BethanysPieShop.Models
{
    public class MockCategoryRepository : ICategoryReporsitory
    {
        public IEnumerable<Category> AllCategories => new List<Category>
        {
            new Category{CategoryId=1, CategoryName="Fruit Pies", Description="All-fruity pies"},
            new Category{CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
            new Category{CategoryId=3, CategoryName="Seasonal pies", Description="Get in them mood for a seasonal  pie"}
        };

    }
}
