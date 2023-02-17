using Microsoft.EntityFrameworkCore;

namespace EspetinhoDoClaudioShop.Models
{
    public class EspetinhoDoClaudioDbContext: DbContext
    {
        public EspetinhoDoClaudioDbContext(DbContextOptions<EspetinhoDoClaudioDbContext>
           options) : base(options)
        {
        }
        
        public DbSet<Category> Categories { get; set; }
        public DbSet<Skewer> Skewers { get; set;  }
    
    }
}
