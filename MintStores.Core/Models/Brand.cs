using System.ComponentModel.DataAnnotations;

namespace MintStores.Core.Model
{
    public class Brand : IBaseModel
    {
        public int BrandId { get; set; }
        [Required]
        public string BrandName { get; set; }
    }
}
