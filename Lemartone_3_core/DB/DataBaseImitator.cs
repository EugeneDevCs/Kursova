using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Lemartone_3_core.Interfaces;
using Lemartone_3_core.Models;
using System.Data.Entity;

namespace Lemartone_3_core.DB
{
    public class DataBaseImitator:DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            //List of products
            context.Products.Add(new Product() { id = 1, name = "FTX-50", shortDesc = "", longDesc = "", img = "imgs/grid_1.jpg", price = 750, isAvailable = true, quantity = 20, categoryId = 1 });
            context.Products.Add(new Product() { id = 2, name = "FTX-30", shortDesc = "", longDesc = "", img = "imgs/grid_1.jpg", price = 650, isAvailable = true, quantity = 20, categoryId = 2 });
            context.Products.Add(new Product() { id = 3, name = "FTX-15", shortDesc = "", longDesc = "", img = "imgs/grid_1.jpg", price = 550, isAvailable = true, quantity = 20, categoryId = 3 });
            context.Products.Add(new Product() { id = 4, name = "FTX-10", shortDesc = "", longDesc = "", img = "imgs/grid_1.jpg", price = 350, isAvailable = true, quantity = 20, categoryId = 4 });
            context.Products.Add(new Product() { id = 5, name = "FTX-51", shortDesc = "", longDesc = "", img = "imgs/grid_1.jpg", price = 751, isAvailable = true, quantity = 20, categoryId = 1 });
            context.Products.Add(new Product() { id = 6, name = "FTX-31", shortDesc = "", longDesc = "", img = "imgs/grid_1.jpg", price = 651, isAvailable = true, quantity = 20, categoryId = 2 });
            context.Products.Add(new Product() { id = 7, name = "FTX-16", shortDesc = "", longDesc = "", img = "imgs/grid_1.jpg", price = 551, isAvailable = true, quantity = 20, categoryId = 3 });
            context.Products.Add(new Product() { id = 8, name = "FTX-11", shortDesc = "", longDesc = "", img = "imgs/grid_1.jpg", price = 351, isAvailable = true, quantity = 20, categoryId = 4 });


            //List of categories
            context.Categories.Add(new Category() { id = 1, categoryName = "Походные рюкзаки" });
            context.Categories.Add(new Category() { id = 2, categoryName = "Городские рюкзаки" });
            context.Categories.Add(new Category() { id = 3, categoryName = "Поясные сумки" });
            context.Categories.Add(new Category() { id = 4, categoryName = "Туристическая переферия" });
            base.Seed(context);
        }
    }
}
