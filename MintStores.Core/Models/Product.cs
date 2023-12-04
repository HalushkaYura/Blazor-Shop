using System.ComponentModel.DataAnnotations;

namespace MintStores.Core.Model
{
    public class Product : IBaseModel
    {
        public int ProductId { get; set; }
        [Required]
        public string ProductName { get; set; }
        [Required]
        public int BrandId { get; set; }
        [Required]
        public int CategoryId { get; set; }
        [Required]
        public short ModelYear { get; set; }
        [Required]
        public decimal Price { get; set; }
    }
}
