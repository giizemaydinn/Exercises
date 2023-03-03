namespace Challenge05.Frontend
{
    static partial class UserProfile
    {
        /// <summary>
        /// Neden static class, interface alamaz??
        /// Neden 15. satır public yapilmayinca ctor'da hata veriyor, UserProfile içinde hata vermiyoor??
        /// </summary>
        public static partial class Basket
        {
            private static List<Product> _products { get; set; }
            private static double _totalPrice { get; set; }
            private static double _minPrice { get; set; }
            private static double _cargoPrice { get; set; }
            static Basket()
            {
                _products = new List<Product>();
                _totalPrice= 0;
                _minPrice = 100;
                _cargoPrice = 10;
                Console.WriteLine("Sepet olusturuldu.\n");
            }

            
        }
    }
    
}
