using System.ComponentModel.DataAnnotations;

namespace MintStores.Core.Model
{
    public class Customer : IBaseModel
    {
        public int CustomerId { get; set; }
        [Required]
        public string FirstName { get; }
        [Required]
        public string LastName { get; }
        public string? Phone { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Streat { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zipcode { get; set; }
    }
}
