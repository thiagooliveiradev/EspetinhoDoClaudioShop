namespace EspetinhoDoClaudioShop.Models
{
    public interface ISkewerRepository
    {
        IEnumerable<Skewer> AllSkewers { get; }
        IEnumerable<Skewer> SkewerOfTheWeek { get; }
        Skewer? GetSkewerById(int skewerId);

    }
}
