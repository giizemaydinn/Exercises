using Business.Base;
using Business.Payment;
using System;

namespace Business.User
{
    public class UserCreditCard : IBase, IActivity
    {
        public int ID { get; set; }
        public int UserID { get; set; }
        public PaymentType Type { get; set; }
        public Provider Provider { get; set; }
        public string CCardNo { get; set; }
        public DateTime Expiry { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }
    }
}
