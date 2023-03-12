////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the IStoreRepository.cs file
//
// The IStoreRepository is used in order to provide an efficient representation of a collection of objects
// which in this case is a collection of Products from the database. CRUD operations are also provided with the
// final three methods in the class.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

namespace RespawnMarket.Models
{
    public interface IStoreRepository
    {
        IQueryable<Product> Products { get; }
        void SaveProduct(Product p);
        void CreateProduct(Product p);
        void DeleteProduct(Product p);
    }
}
