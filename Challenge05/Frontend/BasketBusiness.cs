namespace Challenge05.Frontend
{
    static partial class UserProfile
    {
        /// <summary>
        /// Musterinin sepetinde yapabilecegi islemler burada bulunur.
        /// </summary>
        partial class Basket
        {
            public static void Add(Product product)
            {
                if (product != null)
                {
                    _products.Add(product);
                    _totalPrice += product.Price;
                    Console.WriteLine(product.ProductName + " sepete eklendi. Toplam Fiyat: "+_totalPrice);
                }
                else
                    Console.WriteLine(product.ProductName+" sepete eklenemedi.\n");
            }

            public static (string, bool) CompleteOrder()
            {
                (string s, bool b) = orderSummary();

                //if (_products.Count > 0)
                //{
                //    List<ProductDTO> dto = _mapper.Map<List<Product>, List<ProductDTO>>(_products);
                //    foreach (var i in dto)
                //    {
                //        Console.WriteLine(i.ProductName);
                //    }
                //}

                return (s, b);
            }

            public static List<Product> GetProducts()
            {
                return _products;
            }
            public static void ConfirmCart()
            {
                throw new NotImplementedException();
            }

           
        }
    }
    
}
