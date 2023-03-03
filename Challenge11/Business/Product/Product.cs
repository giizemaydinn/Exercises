using Business.Base;
using System;

namespace Business.Product
{
    public class Product : IBase, IActivity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string SKU { get; set; }
        public ProductCategory Category { get; set; }
        public ProductInventory Inventory { get; set; }
        public decimal Price { get; set; }
        public ProductDiscount Discount { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
