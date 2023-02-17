using EspetinhoDoClaudioShop.Models;

namespace EspetinhoDoClaudioShop.ViewModels
{
    public class SkewerListViewModel
    {
        public IEnumerable<Skewer> Skewers { get; }
        public string? CurrentCategory { get; }

        public SkewerListViewModel(IEnumerable<Skewer> skewers, string? currentCategory)
        { 
            Skewers = skewers;
            CurrentCategory = currentCategory;
        }

            
            
    }
}
