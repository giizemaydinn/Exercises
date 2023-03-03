namespace Challenge03
{
    internal static class Encryption
    {
        private static int _id;
        static Encryption()
        {
            _id = new Random().Next(100, 1000);
        }
        public static string Encrypt(string data)
        {
            return data + _id;
        }

        public static string Decrypt(string data)
        {
            return data + _id;
        }
    }
}
