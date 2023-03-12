////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Full commenting of the Cart.cshtml.cs file
//
// The Cart.cshtml page model class adds products from the database to the cart and updates the ReturnUrl using the OnPost
// method and stores the modified cart using the OnGet method by setting the values of the Cart and ReturnUrl. A new handler
// for the OnPostRemove method is created in order to properly use the remove button in the cart page.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using NuGet.Protocol.Core.Types;
using RespawnMarket.Infrastructure;
using RespawnMarket.Models;
using System.Security.Permissions;

namespace RespawnMarket.Pages
{
    public class CartModel : PageModel
    {
        private IStoreRepository repository;
        public CartModel(IStoreRepository repo, Cart cartServices)
        {
            repository = repo;
            Cart = cartServices;
        }
        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; } = "/";
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
        }
        public IActionResult OnPost(long productId, string returnUrl)
        {
            Product? product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);
            if (product != null)
            {
                Cart.AddItem(product, 1);
            }
            return RedirectToPage(new { returnUrl = returnUrl });
        }
        public IActionResult OnPostRemove(long productId, string returnUrl)
        {
            Cart.RemoveLine(Cart.Lines.First(cl =>
                cl.Product.ProductID == productId).Product);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}

