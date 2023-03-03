namespace Challenge03
{
    internal class User
    {
        public static int ID { get; set; }
        public string Ad { get; set; }
        public int PrivateID { get; set; }
        public User()
        {
            ID++;
            PrivateID = ID;
        }

        public int GetID()
        {
            return ID;
        }
    }
}
