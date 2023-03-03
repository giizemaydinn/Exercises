namespace Challenge02
{
    public class Product
    {
        public int ProductID { get; set; }
        public string ProductCode { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        static int adet = 0;
        private int maxAdet = 50;
        public Product() { }

        public Product(
            int product,
            string productCode,
            string productName,
            double price)
        {
            ProductID = product;
            ProductCode = productCode;
            ProductName = productName;
            Price = price;
        }

        public virtual double SetKdv()
        {
            return Price * 1.18;
        }
        /// <summary>
        /// Satiscinin kullanabilecegi metot.
        /// </summary>
        /// <returns></returns>
        public virtual bool CopeAt()
        {
            return true;
        }

        public virtual bool AdetKontrolu()
        {
            if (adet >= maxAdet)
            {
                Console.WriteLine("Stokta fazla urun var.");
                return false;

            }
            return true;
        }

        public virtual bool KuponKullanilabilirligi()
        {
            return true;
        }

    }
}
