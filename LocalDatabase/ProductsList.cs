using Scarpe___Co_Progetto.Models;

namespace Scarpe___Co_Progetto.LocalDatabase
{
    public static class ProductsList
    {
        private static List<Product> _products = new List<Product>
        {
            new Product
            {
                Id = 1,
                Name = "AIR MAX PLUS",
                Price = 265.00m,
                Description = "High-quality running shoes with exceptional cushioning. Designed to provide all-day comfort, these shoes combine style and performance.",
                MainImage = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/1-copyright-1024x1024.jpg",
                Image2 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/2-copyright-1024x1024.jpg",
                Image3 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/3-copyright-1024x1024.jpg"
            },
            new Product
            {
                Id = 2,
                Name = "TRAIL RUNNING SHOE",
                Price = 189.00m,
                Description = "Trail running shoes designed to tackle difficult terrain. With anti-slip sole and superior ankle support.",
                MainImage = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/2-copyright-1024x1024.jpg",
                Image2 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/1-copyright-1024x1024.jpg",
                Image3 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/4-copyright-1024x1024.jpg"
            },
            new Product
            {
                Id = 3,
                Name = "AIR ZOOM RUN",
                Price = 249.00m,
                Description = "Zoom Air technology for responsive feedback with every step. Lightweight and breathable design for optimal performance.",
                MainImage = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/3-copyright-1024x1024.jpg",
                Image2 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/5-copyright-1024x1024.jpg",
                Image3 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/6-copyright-1024x1024.jpg"
            },
            new Product
            {
                Id = 4,
                Name = "BLAZER MID VINTAGE",
                Price = 245.00m,
                Description = "Vintage style with modern technology. These shoes combine classic looks with contemporary comfort.",
                MainImage = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/4-copyright-1024x1024.jpg",
                Image2 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/8-copyright-1024x1024.jpg",
                Image3 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/1-copyright-1024x1024.jpg"
            },
            new Product
            {
                Id = 5,
                Name = "CLASSIC SNEAKER",
                Price = 199.00m,
                Description = "Classic sneakers that never go out of style. Comfortable for daily use, with minimalist and elegant design.",
                MainImage = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/6-copyright-1024x1024.jpg",
                Image2 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/2-copyright-1024x1024.jpg",
                Image3 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/3-copyright-1024x1024.jpg"
            },
            new Product
            {
                Id = 6,
                Name = "RUNNING PRO",
                Price = 289.00m,
                Description = "Professional shoes for serious runners. Maximum cushioning and stability for long distances.",
                MainImage = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/4-copyright-1024x1024.jpg",
                Image2 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/5-copyright-1024x1024.jpg",
                Image3 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/6-copyright-1024x1024.jpg"
            },
            new Product
            {
                Id = 7,
                Name = "SPORT MAX",
                Price = 270.00m,
                Description = "Maximum performance for every type of sport. Versatile and durable, suitable for intense training.",
                MainImage = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/8-copyright-1024x1024.jpg",
                Image2 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/1-copyright-1024x1024.jpg",
                Image3 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/2-copyright-1024x1024.jpg"
            },
            new Product
            {
                Id = 8,
                Name = "URBAN STYLE",
                Price = 225.00m,
                Description = "Urban design for the modern city. All-day comfort with streetwear style.",
                MainImage = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/5-copyright-1024x1024.jpg",
                Image2 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/8-copyright-1024x1024.jpg",
                Image3 = "https://woohoo.axiomthemes.com/wp-content/uploads/2020/05/4-copyright-1024x1024.jpg"
            }
        };

        public static List<Product> GetAll()
        {
            return _products;
        }

        public static Product? GetById(int id)
        {
            return _products.FirstOrDefault(p => p.Id == id);
        }
    }
}
