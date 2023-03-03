namespace Challenge08
{
    public class Product
    {
        public static int ID { get; set; } = 5;
        public int Id { get; set; }
        public string Name { get; set; }

        public Product() { }
        public Product(string Name)
        {
            Id = ID;
            ID++;
            this.Name = Name;

        }

    }
}