namespace EspetinhoDoClaudioShop.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly EspetinhoDoClaudioDbContext _espetinhoDoClaudinhoDbContext;

        public CategoryRepository(EspetinhoDoClaudioDbContext espetinhoDoClaudinhoDbContext)
        {
            _espetinhoDoClaudinhoDbContext = espetinhoDoClaudinhoDbContext;
        }

        public IEnumerable<Category> AllCategories =>
            _espetinhoDoClaudinhoDbContext.Categories.OrderBy(p => p.CategoryName);
    }
}
