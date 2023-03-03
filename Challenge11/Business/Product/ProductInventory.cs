using Business.Base;
using System;

namespace Business.Product
{
    public class ProductInventory : IBase, IActivity
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
