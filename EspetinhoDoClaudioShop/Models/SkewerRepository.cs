using Microsoft.EntityFrameworkCore;


namespace EspetinhoDoClaudioShop.Models
{
    public class SkewerRepository : ISkewerRepository
    {
        private readonly EspetinhoDoClaudioDbContext _espetinhoDoCLaudioDbContext;

        public SkewerRepository(EspetinhoDoClaudioDbContext espetinhoDoCLaudioDbContext)
        {
            _espetinhoDoCLaudioDbContext = espetinhoDoCLaudioDbContext;
        }

        public IEnumerable<Skewer> AllSkewers
        {
            get
            {
                return _espetinhoDoCLaudioDbContext.Skewers.Include(c => c.Category);
            }
        }

        public IEnumerable<Skewer> SkewerOfTheWeek 
        
        {
            get 
            {
                return _espetinhoDoCLaudioDbContext.Skewers.Include(c => c.Category).Where(p => 
                p.IsSkewerOfTheWeek); 
            }
        }

        public Skewer? GetSkewerById(int skewerId)
        {
            return _espetinhoDoCLaudioDbContext.Skewers.FirstOrDefault(p => p.SkewerId == skewerId);
        }




    }
}
