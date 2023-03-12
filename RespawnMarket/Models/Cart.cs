////////////////////////////////////////////////////////////////////////////////////////////////////////
// Change History
// Date:        Developer:  Description: 
// 2023-03-11   kriner      Commenting of the Cart.cs file
//
// The Cart class implements cart features which uses the CartLine method to define the new lines of items in
// the cart with the product and quantity. There is also the functionality to remove items from the cart line and 
// then the total value of all the items in the cart are added up.
//
// The code used throughout the RespawnMarket program is generally referenced directly from Adam Freeman's
// SportsStore example in the Pro ASP.NET Core 6: Develop Cloud-Ready Web Applications Using MVC, Blazor, and Razor Pages
// book: https://learning.oreilly.com/library/view/pro-asp-net-core/9781484279571/

namespace RespawnMarket.Models
{
    public class Cart
    {
        public List<CartLine> Lines { get; set; } = new List<CartLine>();
        public virtual void AddItem(Product product, int quantity)
        {
            CartLine? line = Lines
                .Where(p => p.Product.ProductID == product.ProductID)
                .FirstOrDefault();
            if (line == null)
            {
                Lines.Add(new CartLine
                {
                    Product = product,
                    Quantity = quantity
                });
            }
            else
            {
                line.Quantity += quantity;
            }
        }
        public virtual void RemoveLine(Product product) =>
            Lines.RemoveAll(l => l.Product.ProductID == product.ProductID);
        public decimal ComputeTotalValue() =>
            Lines.Sum(e => e.Product.Price * e.Quantity);
        public virtual void Clear() => Lines.Clear();
    }
    public class CartLine
    {
        public int CartLineID { get; set; }
        public Product Product { get; set; } = new();
        public int Quantity { get; set; }
    }
}
