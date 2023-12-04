using System.ComponentModel.DataAnnotations;

namespace MintStores.Core.Model
{
    public class Category : IBaseModel
    {
        public int CategoryId { get; set; }
        [Required]
        public string CategoryName { get; set; }
    }
}
