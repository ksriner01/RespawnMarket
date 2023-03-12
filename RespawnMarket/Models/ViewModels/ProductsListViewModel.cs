////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the ProductListViewModel.cs file
//
// The ProductListViewModel class is used to provide the HomeController's Index method with a view of products
// that includes PagingInfo in order to facilitate pagination. The CurrentCategory is also specified in order to
// render the sidebar with all of the product categories.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

namespace RespawnMarket.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set;} = Enumerable.Empty<Product>();
        public PagingInfo PagingInfo { get; set; } = new();
        public string? CurrentCategory { get; set; }
    }
}
