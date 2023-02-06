using System.ComponentModel;

namespace EspetinhoDoClaudioShop.Models
{
    public class Skewer
    {
        public int SkewerId { get; set; }
        public string SkewerName { get; set; } =string.Empty;   
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? AllergyInformation { get; set; }
        public decimal Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsSkewerOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;        

    }
}
