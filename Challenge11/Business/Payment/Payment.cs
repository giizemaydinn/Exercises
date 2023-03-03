using Business.Base;
using System;

namespace Business.Payment
{
    public class Payment : IBase, IActivity
    {
        public int ID { get; set; }
        public int Amount { get; set; }
        public Provider Provider { get; set; }
        public PaymentType Type { get; set; }
        public PaymentStatus Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
