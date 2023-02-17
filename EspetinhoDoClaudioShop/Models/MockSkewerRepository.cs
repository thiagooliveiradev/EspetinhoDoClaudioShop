namespace EspetinhoDoClaudioShop.Models
{
    public class MockSkewerRepository : ISkewerRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Skewer> AllSkewers =>          
            new List<Skewer>
            {
                new Skewer {SkewerId = 1, SkewerName="Espetinho de picanha", Price=17.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Skewer chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Skewer muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Skewer cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://i.pinimg.com/564x/1d/ef/56/1def56d47e9c287badd478b1a8e37f66.jpg", InStock=true, IsSkewerOfTheWeek=false, ImageThumbnailUrl="https://i.pinimg.com/564x/1d/ef/56/1def56d47e9c287badd478b1a8e37f66.jpg"},
                new Skewer {SkewerId = 2, SkewerName="Espetinho de frango", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Skewer chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Skewer muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Skewer cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://i.pinimg.com/564x/3f/e6/34/3fe63463287d0df15d8cb8573442167a.jpg", InStock=true, IsSkewerOfTheWeek=false, ImageThumbnailUrl="https://i.pinimg.com/564x/3f/e6/34/3fe63463287d0df15d8cb8573442167a.jpg"},
                new Skewer {SkewerId = 3, SkewerName="Espetinho de legumes", Price=11.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Skewer chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Skewer muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Skewer cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://i.pinimg.com/564x/1a/5b/72/1a5b72382f20909fa1a1ea618620846a.jpg", InStock=true, IsSkewerOfTheWeek=true, ImageThumbnailUrl="https://i.pinimg.com/564x/1a/5b/72/1a5b72382f20909fa1a1ea618620846a.jpg"},
                new Skewer {SkewerId = 4, SkewerName="Espetinho de cafta", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Skewer chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Skewer muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Skewer cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://i.pinimg.com/564x/6f/2f/5a/6f2f5a869e07bab2bb9d1659c47ebc78.jpg", InStock=true, IsSkewerOfTheWeek=true, ImageThumbnailUrl="https://i.pinimg.com/564x/6f/2f/5a/6f2f5a869e07bab2bb9d1659c47ebc78.jpg"}
            };

        public IEnumerable<Skewer> SkewerOfTheWeek
        {
            get
            {
                return AllSkewers.Where(p => p.IsSkewerOfTheWeek);                                                                          
            }
        }

        public Skewer? GetSkewerById(int skewerId) => AllSkewers.FirstOrDefault(p => p.SkewerId == skewerId);

        public IEnumerable<Skewer> SearchSkewers(string searchQuery)
        {
            throw new NotImplementedException();
        }
    }
}
