using System.ComponentModel.DataAnnotations;

namespace MintStores.Core.Model
{
    public class Staff : IBaseModel
    {
        public int StaffId { get; set; }
        [Required]
        public string FirstName { get; }
        [Required]
        public string LastName { get; set; }
        [Required]
        public string Email { get; set; }
        public string? Phone { get; set; }
        public bool? Active { get; set; }
        [Required]
        public int StoreId { get; set; }
        public int? ManagerId { get; set; }
    }
}
