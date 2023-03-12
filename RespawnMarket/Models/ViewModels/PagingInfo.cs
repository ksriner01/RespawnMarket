////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the PagingInfo.cs file
//
// The PagingInfo class is a View Model that passes information about pages from the controller to the view.
// The specific information are the total items (products), the items per page, the current pagem and the
// total amount of pages calculated by dividing the total items by how many items will be displayed on the page.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

namespace RespawnMarket.Models.ViewModels
{
    public class PagingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((decimal)TotalItems / ItemsPerPage);
    }
}
