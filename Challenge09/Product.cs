namespace Challenge09
{
    public class Product
    {
        private static int ID = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }

        public Product() { }
        public Product(string name, double price)
        {
            Id = ID++;
            Name = name;
            Price = price;
        }
    }
}
