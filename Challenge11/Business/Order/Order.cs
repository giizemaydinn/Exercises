using Business.Base;
using Pay = Business.Payment;
using System;

namespace Business.Order
{
    public class Order : IBase, IActivity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public decimal Total { get; set; }
        public Pay::Payment Payment { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
