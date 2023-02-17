namespace EspetinhoDoClaudioShop.Models
{
    public static class DbInitializer
    {
        public static void Seed(IApplicationBuilder applicationBuilder)
        {
            EspetinhoDoClaudioDbContext context =
                applicationBuilder.ApplicationServices.CreateScope
                ().ServiceProvider.GetRequiredService<EspetinhoDoClaudioDbContext>();

            if (!context.Categories.Any())
            {
                context.Categories.AddRange(Categories.Select(c => c.Value));
            }

            if (!context.Skewers.Any())
            {
                context.AddRange
                (
                    new Skewer { SkewerName = "Espetinho de carne bovina", Price = 8.00M, ShortDescription = "A suculência no palito!", LongDescription = "", Category = Categories["Queridinhos"], ImageUrl = "https://i.pinimg.com/564x/1d/ef/56/1def56d47e9c287badd478b1a8e37f66.jpg", InStock = true, IsSkewerOfTheWeek = true, ImageThumbnailUrl = "https://i.pinimg.com/564x/1d/ef/56/1def56d47e9c287badd478b1a8e37f66.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de frango", Price = 7.50M, ShortDescription = "A proteína em forma de espetinho!", LongDescription = "", Category = Categories["Queridinhos"], ImageUrl = "https://i.pinimg.com/564x/bd/aa/14/bdaa14568fae40acbc1f2d8588329dd3.jpg", InStock = true, IsSkewerOfTheWeek = true, ImageThumbnailUrl = "https://i.pinimg.com/564x/bd/aa/14/bdaa14568fae40acbc1f2d8588329dd3.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de linguiça", Price = 7.00M, ShortDescription = "O tempero em um palito crocante!", LongDescription = "", Category = Categories["Queridinhos"], ImageUrl = "https://i.pinimg.com/564x/14/60/28/146028d43977dcac0d264910476a1660.jpg", InStock = true, IsSkewerOfTheWeek = true, ImageThumbnailUrl = "https://i.pinimg.com/564x/14/60/28/146028d43977dcac0d264910476a1660.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de coração de frango", Price = 8.00M, ShortDescription = "O amor no espetinho!", LongDescription = "", Category = Categories["Queridinhos"], ImageUrl = "https://i.pinimg.com/564x/88/f3/32/88f332887b705ffc7bbd027a29386447.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/88/f3/32/88f332887b705ffc7bbd027a29386447.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de queijo coalho", Price = 10.00M, ShortDescription = "O sabor celestial no palito!", LongDescription = "", Category = Categories["Queridinhos"], ImageUrl = "https://i.pinimg.com/564x/8f/72/b5/8f72b534a9b9be191acebecd6dd92a43.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/8f/72/b5/8f72b534a9b9be191acebecd6dd92a43.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de camarão", Price = 13.00M, ShortDescription = "O mar em forma de petisco!	a", LongDescription = "", Category = Categories["Espetinhos Premium"], ImageUrl = "https://i.pinimg.com/564x/55/28/fd/5528fdc7c53d021d8277d4dbbfbc911e.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/55/28/fd/5528fdc7c53d021d8277d4dbbfbc911e.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de peixe", Price = 12.00M, ShortDescription = "O sabor do oceano no espetinho!", LongDescription = "", Category = Categories["Espetinhos Premium"], ImageUrl = "https://i.pinimg.com/564x/03/b4/9a/03b49ae192233fff29877943ce0c5261.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/03/b4/9a/03b49ae192233fff29877943ce0c5261.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de carne suína", Price = 8.00M, ShortDescription = "A suculência do porco em um palito!", LongDescription = "", Category = Categories["Queridinhos"], ImageUrl = "https://i.pinimg.com/564x/e1/d3/2b/e1d32bf3a7745351894c3c41cf113f39.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/e1/d3/2b/e1d32bf3a7745351894c3c41cf113f39.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de carneiro", Price = 12.00M, ShortDescription = "O sabor nobre no palito!", LongDescription = "", Category = Categories["Espetinhos Premium"], ImageUrl = "https://i.pinimg.com/564x/02/38/68/023868f6b96b6b697b9bc540d52897ee.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/02/38/68/023868f6b96b6b697b9bc540d52897ee.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de cogumelos", Price = 8.50M, ShortDescription = "O sabor da floresta em um palito!", LongDescription = "", Category = Categories["Espetinhos vegetarianos"], ImageUrl = "https://i.pinimg.com/564x/96/94/2a/96942a6a3ecc094358b9408ced5e7db2.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/96/94/2a/96942a6a3ecc094358b9408ced5e7db2.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de legumes", Price = 8.00M, ShortDescription = "A natureza no espetinho!", LongDescription = "", Category = Categories["Espetinhos vegetarianos"], ImageUrl = "https://i.pinimg.com/564x/37/dd/bc/37ddbca40d167b8983b86c85ca0c1e3c.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/37/dd/bc/37ddbca40d167b8983b86c85ca0c1e3c.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de tofu", Price = 11.00M, ShortDescription = "O poder da soja no espetinho!", LongDescription = "", Category = Categories["Espetinhos vegetarianos"], ImageUrl = "https://i.pinimg.com/564x/68/f5/07/68f5074fdb70588aafd1dcd90cc22e27.jpg", InStock = false, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/68/f5/07/68f5074fdb70588aafd1dcd90cc22e27.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de picanha", Price = 17.00M, ShortDescription = "O sabor nobre em um palito de carne!", LongDescription = "", Category = Categories["Espetinhos Premium"], ImageUrl = "https://i.pinimg.com/564x/74/a8/6d/74a86da891beb6f32043582edf7e1a3c.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/74/a8/6d/74a86da891beb6f32043582edf7e1a3c.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de Salmão", Price = 18.00M, ShortDescription = "A tentação suculenta que você precisa experimentar agora!", LongDescription = "", Category = Categories["Espetinhos Premium"], ImageUrl = "https://i.pinimg.com/564x/44/ac/05/44ac05220d3e5e07d30d0462917862f0.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/44/ac/05/44ac05220d3e5e07d30d0462917862f0.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de salsicha", Price = 6.00M, ShortDescription = "O sabor da infância em um palito crocante!", LongDescription = "", Category = Categories["Queridinhos"], ImageUrl = "https://i.pinimg.com/564x/92/71/1d/92711df735ff3d98140c6806aa5e4fb3.jpg", InStock = true, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/92/71/1d/92711df735ff3d98140c6806aa5e4fb3.jpg", AllergyInformation = "" },
                    new Skewer { SkewerName = "Espetinho de carne de sol", Price = 15.00M, ShortDescription = "O sabor típico do Nordeste no palito!", LongDescription = "", Category = Categories["Espetinhos Premium"], ImageUrl = "https://i.pinimg.com/564x/f0/4d/f9/f04df94026cef8cfc8969e9cf03eaf7b.jpg", InStock = false, IsSkewerOfTheWeek = false, ImageThumbnailUrl = "https://i.pinimg.com/564x/f0/4d/f9/f04df94026cef8cfc8969e9cf03eaf7b.jpg", AllergyInformation = "" }
                );
            }

            context.SaveChanges();
        }

        private static Dictionary<string, Category>? categories;

        public static Dictionary<string, Category> Categories
        {
            get
            {
                if (categories == null)
                {
                    var genresList = new Category[]
                    {
                        new Category { CategoryName = "Queridinhos" },
                        new Category { CategoryName = "Espetinhos vegetarianos" },
                        new Category { CategoryName = "Espetinhos Premium" }
                    };

                    categories = new Dictionary<string, Category>();

                    foreach (Category genre in genresList)
                    {
                        categories.Add(genre.CategoryName, genre);
                    }
                }

                return categories;
            }
        }
    }
}