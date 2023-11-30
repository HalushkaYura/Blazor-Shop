﻿namespace MintStores.Core.Model
{
    public class Customer : IBaseModel
    {
        public int CustomerId { get; set; }
        public string FirstName { get; }
        public string LastName { get; }
        public string? Phone { get; set; }
        public string Email { get; set; }
        public string? Streat { get; set; }
        public string? City { get; set; }
        public string? State { get; set; }
        public string? Zipcode { get; set; }
    }
}