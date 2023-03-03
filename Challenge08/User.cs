namespace Challenge08
{
    public class User
    {
        public static List<User> Users = new List<User>();
        public static int ID { get; set; } = 0;
        public int Id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public List<Product> Products { get; set; }
        public User(string name, string password)
        {
            Products = new List<Product>();
            Id = ID;
            ID++;
            UserName = name;
            Password = password;
        }
        public void AddProduct(Product product)
        {
            Products.Add(product);
        }

        public bool isLogin(string username, string password)
        {
            if (username.Length > 0 && password.Length > 0)
            {
                foreach (var item in Users)
                {
                    if (item.UserName == username && item.Password == username)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
