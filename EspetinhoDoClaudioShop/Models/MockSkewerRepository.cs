namespace EspetinhoDoClaudioShop.Models
{
    public class MockSkewerRepository : ISkewerRepository
    {
        private readonly ICategoryRepository _categoryRepository = new MockCategoryRepository();

        public IEnumerable<Skewer> AllSkewers =>          
            new List<Skewer>
            {
                new Skewer {SkewerId = 1, SkewerName="Espetinho de picanha", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Skewer chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Skewer muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Skewer cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanysSkewershop/fruitSkewers/strawberrySkewer.jpg", InStock=true, IsSkewerOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanysSkewershop/fruitSkewers/strawberryPiesmall.jpg"},
                new Skewer {SkewerId = 2, SkewerName="Espetinhos de frango", Price=18.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Skewer chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Skewer muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Skewer cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[1],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanysSkewershop/cheesecakes/cheesecake.jpg", InStock=true, IsSkewerOfTheWeek=false, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanysPieshop/cheesecakes/cheesecakesmall.jpg"},
                new Skewer {SkewerId = 3, SkewerName="Espetinhos de legumes", Price=15.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Skewer chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Skewer muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Skewer cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[2],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanysSkewershop/fruitSkewers/rhubarbSkewer.jpg", InStock=true, IsSkewerOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanysPieshop/fruitSkewers/rhubarbSkewersmall.jpg"},
                new Skewer {SkewerId = 4, SkewerName="Espetinhos de cafta", Price=12.95M, ShortDescription="Lorem Ipsum", LongDescription="Icing carrot cake jelly-o cheesecake. Sweet roll marzipan marshmallow toffee brownie brownie candy tootsie roll. Chocolate cake gingerbread tootsie roll oat cake Skewer chocolate bar cookie dragée brownie. Lollipop cotton candy cake bear claw oat cake. Dragée candy canes dessert tart. Marzipan dragée gummies lollipop jujubes chocolate bar candy canes. Icing gingerbread chupa chups cotton candy cookie sweet icing bonbon gummies. Gummies lollipop brownie biscuit danish chocolate cake. Danish powder cookie macaroon chocolate donut tart. Carrot cake dragée croissant lemon drops liquorice lemon drops cookie lollipop toffee. Carrot cake carrot cake liquorice sugar plum topping bonbon Skewer muffin jujubes. Jelly pastry wafer tart caramels bear claw. Tiramisu tart Skewer cake danish lemon drops. Brownie cupcake dragée gummies.", Category = _categoryRepository.AllCategories.ToList()[0],ImageUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanysSkewershop/seasonal/pumpkinSkewer.jpg", InStock=true, IsSkewerOfTheWeek=true, ImageThumbnailUrl="https://gillcleerenpluralsight.blob.core.windows.net/files/bethanysPieshop/seasonal/pumpkinSkewersmall.jpg"}
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
