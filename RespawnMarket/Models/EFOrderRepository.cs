////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the EFOrderRepository.cs file
//
// The EFOrderRepository class implement the IOrderRepository class and allows for the orders stored in the IOrderRepository
// to be accessed, created, and changed.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

using Microsoft.EntityFrameworkCore;

namespace RespawnMarket.Models
{
    public class EFOrderRepository : IOrderRepository
    {
        private StoreDbContext context;
        public EFOrderRepository(StoreDbContext ctx)
        {
            context = ctx;
        }
        public IQueryable<Order> Orders => context.Orders
                            .Include(o => o.Lines)
                            .ThenInclude(l => l.Product);
        public void SaveOrder(Order order)
        {
            context.AttachRange(order.Lines.Select(l => l.Product));
            if (order.OrderID == 0)
            {
                context.Orders.Add(order);
            }
            context.SaveChanges();
        }
    }
}