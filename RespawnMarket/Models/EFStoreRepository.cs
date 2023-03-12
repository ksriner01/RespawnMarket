////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the EFStoreRepository.cs file
//
// The EFStoreRepository class first declares the context it works with, in this case the StoreDbContext and
// maps the Products property from the IStoreRepository to the context which returns a DbSet<Product> object.
// The EFStoreRepository also allows for the creation, delete, and saving of products to the context.
// Implements the methods from IStoreRepository that manage CRUD capabilities for the store context.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using Microsoft.EntityFrameworkCore;
namespace RespawnMarket.Models
{
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbContext context;
        public EFStoreRepository(StoreDbContext ctx) { 
            context = ctx;
        }
        public IQueryable<Product> Products => context.Products;
        public void CreateProduct(Product p)
        {
            context.Add(p);
            context.SaveChanges();
        }
        public void DeleteProduct(Product p)
        {
            context.Remove(p);
            context.SaveChanges();
        }
        public void SaveProduct(Product p)
        {
            context.SaveChanges();
        }
    }
}
