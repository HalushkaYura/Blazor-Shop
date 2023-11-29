namespace MintStores.Models
{
    public class Staff
    {
        public int StaffId { get; set; }
        public string FirstName { get;}
        public string LastName { get; set; }
        public string Email { get; set; }   
        public string? Phone { get; set; }
        public bool? Active { get; set; }
        public int StoreId { get; set;}
        public int? ManagerId { get; set; }
    }
}
