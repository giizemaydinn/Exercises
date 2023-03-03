namespace Challenge03
{
    internal static class Database
    {
        private static string user = "";
        private static string password = "";
        private static List<User> users = new List<User>();

        /// <summary>
        /// Baglanti islemleri icin kullanilacak ctor.
        /// </summary>
        static Database()
        {
            user = "gizem";
            password = "Password";
            Connect();
        }

        /// <summary>
        /// DB baglantisinin gerceklestigi func.
        /// </summary>
        private static void Connect()
        {
            Console.WriteLine(user + " DB'ye baglandi...");

        }

        private static void DisConnect()
        {
            Console.WriteLine(user + " baglanti kapatildi...");

        }

        /// <summary>
        /// Gonderilen deger kontrol edilerek db'ye eklenir.
        /// </summary>
        /// <param name="user"></param>
        public static void Add(User user)
        {
            Console.WriteLine("Eklendi " + user.Ad + " " + user.PrivateID);
            users.Add(user);
        }


    }
}
