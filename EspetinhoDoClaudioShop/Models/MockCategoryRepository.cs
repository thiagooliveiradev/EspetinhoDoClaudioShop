namespace EspetinhoDoClaudioShop.Models
{
    public class MockCategoryRepository : ICategoryRepository
    {
        public IEnumerable<Category> AllCategories =>
            new List<Category>()
            {
             new Category{CategoryId=1, CategoryName="Espetinhos de carne", Description="Todos os espetinhos de carne" },
             new Category{CategoryId=2, CategoryName="Espetinhos de frango", Description="Para os amantes de frango, todos os nossos espetinhos de frango" },
             new Category{CategoryId=3, CategoryName="Espetinhos vegetarianos", Description="Também não esquecemos de vocês!  todos os nossos espetinhos vegetarianos" }
            };
    }
}
