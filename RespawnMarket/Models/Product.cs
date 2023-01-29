using System.ComponentModel.DataAnnotations.Schema;

namespace RespawnMarket.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public string ProductType { get; set; }
        [Column(TypeName = "decimal(8, 2)")]
        public decimal ProductPrice { get; set; }
    }
}
