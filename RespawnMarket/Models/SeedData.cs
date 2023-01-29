using Microsoft.EntityFrameworkCore;
using RespawnMarket.Data;

namespace RespawnMarket.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            ProductContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<ProductContext>();
            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }
            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        ProductName = "Call of Duty",
                        ProductDescription = "Critically acclaimed first-person shooter.",
                        ProductType = "Video Game",
                        ProductPrice = 59.99m
                    },
                    new Product
                    {
                        ProductName = "RTX 3070 Graphics Card",
                        ProductDescription = "High end graphics card tuned for gaming.",
                        ProductType = "Video Card",
                        ProductPrice = 569.99m
                    }
                ); 
                context.SaveChanges();
            }
        }
    }
}
