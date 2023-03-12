////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the HomeController.cs file
//
// The HomeController class provides a controller that handles HTTP requests by using an EFStoreRepository object
// for every request that maps to the IStoreRepository. Pagination is also added to the controller by specifiying
// the PageSize which is the products per page and then ordering by productID (the primary key), skipping the rest of
// the products that appear before the next page and take the next PageSize value of products to display on the next page,
// or if there are less than the PageSize value, displays the remainder of the products.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using Microsoft.AspNetCore.Mvc;
using RespawnMarket.Models;
using RespawnMarket.Models.ViewModels;
namespace RespawnMarket.Controllers
{
    public class HomeController: Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;
        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        // Uses a string category to determine which category the user is looking at and sets the productPage
        // to 1 for the first page. Also creates a new ProductListViewModel to display the Product list.
        public ViewResult Index(string? category, int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                    .Where(p => category == null || p.Category == category)
                    .OrderBy(p => p.ProductID)
                    .Skip((productPage - 1) * PageSize)
                    .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = category == null
                        ? repository.Products.Count()
                        : repository.Products.Where(e =>
                            e.Category == category).Count()
                },
                CurrentCategory= category
            });

    }
}
