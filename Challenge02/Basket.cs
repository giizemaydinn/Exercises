namespace Challenge02
{
    internal class Basket
    {
        private List<Product> products = new List<Product>();
        private double minTotal = 100;
        private bool kupon = true;
        public void Add(Product product)
        {
            if (product != null)
                products.Add(product);

            ////v1

            //if (product.GetType() == typeof(Bread))
            //    Console.WriteLine("Bread");

            ////v2

            //if(product is Bread)
            //    Bread br = (Bread)product;

            //v3
            //if(product is Bread)
            //    Bread bread = product as Bread;
        }
        public double TotalPrice()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.Price;
            }
            return totalPrice;
        }

        public double TotalPriceWithKDV()
        {
            double totalPrice = 0;
            foreach (Product product in products)
            {
                totalPrice += product.SetKdv();
            }
            return totalPrice;
        }

        public List<Product> GetProducts()
        {
            return products;
        }
        /// <summary>
        /// Sepetteki toplam fiyat min fiyattan kucukse islem tamamlanamaz.
        /// </summary>
        /// <returns></returns>
        public bool Buy()
        {
            if (minTotal > TotalPrice())
                return false;
            return true;
        }
    }
}
