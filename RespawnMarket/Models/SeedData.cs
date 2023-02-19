using Microsoft.EntityFrameworkCore;
namespace RespawnMarket.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices.CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (!context.Products.Any())
            {
                context.Products.AddRange(
                    new Product
                    {
                        Name = "Call of Duty: Modern Warfare 2",
                        Description = "Call of Duty: Modern Warfare II is a 2022 first-person shooter game developed by Infinity Ward " +
                        "and published by Activision. It is a sequel to the 2019 reboot, and serves as the nineteenth installment in " +
                        "the overall Call of Duty series.",
                        Category = "Video Game",
                        Price = 79.99m
                    },
                    new Product
                    {
                        Name = "NVIDIA - GeForce RTX 3070 Ti",
                        Description = "The GeForce RTX™ 3070 Ti is powered by Ampere— NVIDIA’s 2nd gen RTX architecture. Built with " +
                        "enhanced RT Cores and Tensor Cores, new streaming multiprocessors, and superfast G6X memory",
                        Category = "Computer Component",
                        Price = 599.99m
                    },
                    new Product
                    {
                        Name = "Intel - Core i7-13700K 13th Gen",
                        Description = "13th Gen Intel Core i7-13900K desktop processor. Featuring Intel Turbo Boost Max Technology 3.0, " +
                        "and PCIe 5.0 and 4.0 support, DDR5 and DDR4 support",
                        Category = "Computer Component",
                        Price = 489.99m
                    },
                    new Product
                    {
                        Name = "Grand Theft Auto V Standard Edition",
                        Description = "Includes Grand Theft Auto V: Story Mode and Grand Theft Auto Online.",
                        Category = "Video Game",
                        Price = 39.99m
                    },
                    new Product
                    {
                        Name = "Sony - Playstation 5 Console",
                        Description = "The PS5 console unleashes new gaming possibilities that you never anticipated. Experience lightning " +
                        "fast loading with an ultra-high speed SSD, deeper immersion with support for haptic feedback, adaptive triggers, " +
                        "and 3D Audio*, and an all-new generation of incredible PlayStation games.",
                        Category = "Console",
                        Price = 499.99m
                    },
                    new Product
                    {
                        Name = "Microsoft - Xbox Series X 1TB Console",
                        Description = "Xbox Series X, the fastest, most powerful Xbox ever. Explore rich new worlds with 12 teraflops " +
                        "of raw graphic processing power, DirectX ray tracing, a custom SSD, and 4K gaming.",
                        Category = "Console",
                        Price = 499.99m
                    },
                    new Product
                    {
                        Name = "The Last of Us Part II Standard Edition",
                        Description = "The Last of Us Part II is a 2020 action-adventure game developed by Naughty Dog and published by " +
                        "Sony Interactive Entertainment for the PlayStation 4.",
                        Category = "Video Game",
                        Price = 29.95m
                    }
                );
                context.SaveChanges();
            }
        }
    }
}
