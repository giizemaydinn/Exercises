using System.Text.Json;

namespace Challenge05.Frontend
{
    static partial class UserProfile
    {
        static partial class Basket
        {
            private static (string, bool) orderSummary()
            {
                if (!controlMinPrice())
                {
                    return ("Siparisiniz minimum tutarin altindadir.", false);
                }
                string fileName = "OrderSummary.json";
                string jsonString = JsonSerializer.Serialize(Basket._products);
                File.WriteAllText(fileName, jsonString);

                Console.WriteLine("\nSipariş özeti oluşturuldu.");
                Console.WriteLine(File.ReadAllText(fileName) + "\n");

                foreach (var item in _products)
                {
                    Console.WriteLine(item.ProductName + "-" + item.Price);
                }

                return ("Siparis ozetiniz olusturulmustur.",true);
            }

            private static void calculateCoupon()
            {
                throw new NotImplementedException();
            }

            private static void calculateCargoPrice()
            {
                throw new NotImplementedException();
            }

            private static bool controlMinPrice()
            {
               if(_minPrice > _totalPrice)
                {
                    Console.WriteLine("Sepet tutarı " + _minPrice + " TL'den az.");
                    return false;
                }
                return true;
            }

            private static void warningMinPrice()
            {
                throw new NotImplementedException();
            }
        }
    }
    
}
