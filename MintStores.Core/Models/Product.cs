﻿namespace MintStores.Core.Model
{
    public class Product : IBaseModel
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int BrandId { get; set; }
        public int CategoryId { get; set; }
        public short ModelYear { get; set; }
        public decimal Price { get; set; }
    }
}
