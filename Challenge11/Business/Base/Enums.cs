namespace Business.Base
{
    public enum PhoneType
    {
        Home = 0,
        Work = 1,
    }

    public enum PaymentType
    {
        CC = 0,
        OnlinePaymentProvider = 1,
        Transfer = 2,
        Cash = 3,
    }

    public enum PaymentStatus
    {
        NotPaid = 0,
        Processing = 1,
        Paid = 2,
    }
}
