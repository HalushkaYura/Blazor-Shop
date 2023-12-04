using System.ComponentModel.DataAnnotations;

namespace MintStores.Core.Model
{
    public class Order : IBaseModel
    {
        public int OrderId { get; set; }
        public int? CustomerId { get; set; }
        [Required]
        public int OrderStatus { get; set; }
        [Required]
        public DateTime OrderDate { get; set; }
        [Required]
        public DateTime RequiredDate { get; set; }
        public DateTime? ShippedDate { get; }
        [Required]
        public int StoreId { get; set; }
        [Required]
        public int StaffId { get; set; }
    }
}
