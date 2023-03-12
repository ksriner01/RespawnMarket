////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the LoginModel.cs file
//
// The LoginModel class allows for unauthorized users to be taken to the Login page to provide credentials such
// as name and password and a ReturnUrl to send the user to.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using System.ComponentModel.DataAnnotations;
namespace RespawnMarket.Models.ViewModels
{
    public class LoginModel
    {
        [Required]
        public string? Name { get; set; }
        [Required]
        public string? Password { get; set; }
        public string ReturnUrl { get; set; } = "/";
    }
}
