namespace ScatResale.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using Microsoft.EntityFrameworkCore.Internal;
    using ScatResale.Data.Models;

    public class MainCategoriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.MainCategories.Any())
            {
                return;
            }

            var mainCategories = new List<(string Name, string ImageUrl)>
            {
                ("Ski", "https://www.hamburg-airport.de/images/Ski-Fluege_940.jpg"),
                ("Cycling", "https://www.highlandbikes.com/images/tcxslr1.jpg"),
                ("Mountaineering", "https://www.petzl.com/sfc/servlet.shepherd/version/download/068w0000004nLZcAAM"),
                ("Tourism", "https://www.skibansko.bg/uploaded_files/pirinrila-new-3.jpg"),
                ("Clothing", "https://encrypted-tbn0.gstatic.com/images?q=tbn%3AANd9GcQRIPLFN_wjBRhMQeeedsiMup6b8-kuw2E4TyP5J8WTcebky39Q&usqp=CAU"),
                ("Shoes", "https://productimage001.cotswoldoutdoor.com/productimages/580x580/b21120613636bb.jpg"),
            };

            foreach (var (name, imageUrl) in mainCategories)
            {
                await dbContext.MainCategories.AddAsync(new MainCategory()
                {
                    Name = name,
                    Icon = imageUrl,
                });
            }
        }
    }
}
