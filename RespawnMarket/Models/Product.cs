////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the Product.cs file
//
// The Product class defines a Product entity with the ProductID, Name, Description, Price, and Category properties.
// This is the main model for all products that are displayed on the website. Added validation attributes to the 
// products properties that make them required and provide error messages if they don't enter a properties. 
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace RespawnMarket.Models
{
    public class Product
    {
        public long? ProductID { get; set; }
        [Required(ErrorMessage = "Please enter a product name")]
        public string Name { get; set; } = String.Empty;
        [Required(ErrorMessage = "Please enter a description"), StringLength(500), DataType(DataType.MultilineText)]
        public string Description { get; set; } = String.Empty;
        [Required]
        [Range(0.01, double.MaxValue,
            ErrorMessage = "Please enter a positive price")]
        [Column(TypeName = "decimal(8, 2)"), DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required(ErrorMessage = "Please specify a category"), StringLength(50)]
        public string Category { get; set; } = String.Empty;
    }
}
