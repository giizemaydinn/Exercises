namespace Challenge05.Frontend
{

    static partial class UserProfile
    {
        private static List<int> _coupons { get; set; }
        private static string _address { get; set; }
        private static string _email { get; set; }
        private static string _password { get; set; }

        static UserProfile()
        {
            _address= string.Empty;
            _email= string.Empty;
            _password= string.Empty;
            _coupons = new List<int>();

            defineCoupon();

            Console.WriteLine("Profil tanımlandı.\n");
        }

        public static void Welcome()
        {
            Console.WriteLine("HOŞGELDİNİZ..");
        }
        public static void UpdateEmail(string email)
        {
            _email = email;
        }

        public static void UpdatePassword(string password)
        {
            _password = password;
        }

        public static void UpdateAddress(string address)
        {
            _address= address;
        }

        private static void defineCoupon()
        {
            Random random = new Random();
            int coupon = random.Next(50, 200);
            _coupons.Add(coupon);
        }
        static partial class Basket { }


    }
}
