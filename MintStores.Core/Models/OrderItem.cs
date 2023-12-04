using System.ComponentModel.DataAnnotations;

namespace MintStores.Core.Model
{
    public class OrderItem : IBaseModel
    {
        public int OrderId { get; set; }
        
        public int ItemId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal Price { get; set; }
        [Required]
        public decimal Discount { get; set; }
    }
}
