using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using RespawnMarket.Data;
using RespawnMarket.Models;

namespace RespawnMarket.Pages.Products
{
    public class IndexModel : PageModel
    {
        private readonly RespawnMarket.Data.ProductContext _context;

        public IndexModel(RespawnMarket.Data.ProductContext context)
        {
            _context = context;
        }

        public IList<Product> Product { get;set; } = default!;

        public async Task OnGetAsync()
        {
            if (_context.Products != null)
            {
                Product = await _context.Products.ToListAsync();
            }
        }
    }
}
