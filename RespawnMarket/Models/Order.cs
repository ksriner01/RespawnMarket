////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the Order.cs file
//
// The Order class defines an Order entity with properties relating to the OrderID and shipping details of the
// customer.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.ModelBinding;
namespace RespawnMarket.Models
{
    public class Order
    {
        [BindNever]
        public int OrderID { get; set; }
        [BindNever]
        public ICollection<CartLine> Lines { get; set; } = new List<CartLine>();
        [Required(ErrorMessage = "Please enter a name")]
        public string? Name { get; set; }
        [Required(ErrorMessage = "Please enter the first address line"), StringLength(50), DisplayFormat(NullDisplayText = "No Address")]
        public string? Line1 { get; set; }
        [StringLength(50)]
        public string? Line2 { get; set; }
        [StringLength(50)]
        public string? Line3 { get; set; }
        [Required(ErrorMessage = "Please enter a city name"), StringLength(50), DisplayFormat(NullDisplayText = "No City")]
        public string? City { get; set; }
        [Required(ErrorMessage = "Please enter a state name"), StringLength(50), DisplayFormat(NullDisplayText = "No State")]
        public string? State { get; set; }
        [Required(ErrorMessage = "Please enter a postal code"), DataType(DataType.PostalCode), DisplayFormat(NullDisplayText = "No Postal Code")]
        public string? Zip { get; set; }
        [Required(ErrorMessage = "Please enter a country name"), StringLength(50), DisplayFormat(NullDisplayText = "No Country")]
        public string? Country { get; set; }
        public bool GiftWrap { get; set; }
        [BindNever]
        public bool Shipped { get; set; }
    }
}
