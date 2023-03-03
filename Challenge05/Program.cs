using Challenge05;
using Challenge05.Frontend;

class Program
{
    /// <summary>
    /// Partial class - json ornegi.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        bool start = true;
        UserProfile.Welcome();
        StartApp();
        //Console.WriteLine(typeof(UserProfile.Basket));



        while (start)
        {
            Bread ekmek = new Bread(BreadType.Kepek);
            ekmek.Price = 10;
            ekmek.ProductName = "Kepekli Ekmek";

            Bread ekmek1 = new Bread(BreadType.AltinEkmek);
            ekmek1.Price = 10;
            ekmek1.ProductName = "Altin Ekmek";

            Yogurt yogurt = new Yogurt(new DateTime(2023, 10, 11), new DateTime(2022, 12, 11), 0.5, 40, "İçim", true, Fat.HalfFat);
            yogurt.Price = 40;
            yogurt.ProductName = "Yogurt";

            UserProfile.Basket.Add(yogurt);
            UserProfile.Basket.Add(ekmek);
            UserProfile.Basket.Add(ekmek1);

            (string s, bool b) = UserProfile.Basket.CompleteOrder();
            Console.WriteLine(s);
            start = Continue(b);

        }

    }

    public static void StartApp()
    {
        Console.WriteLine("Email: ");
        UserProfile.UpdateEmail(Console.ReadLine());
        Console.WriteLine("Password: ");
        UserProfile.UpdatePassword(Console.ReadLine());
        Console.WriteLine("Address: ");
        UserProfile.UpdateAddress(Console.ReadLine());
    }

    public static (string, bool) CompleteOrder()
    {
        return UserProfile.Basket.CompleteOrder();
    }

    public static bool Continue(bool con)
    {
        if (con)
        {
            Console.WriteLine("1. Alışverişe devam et veya 2. Alışverişi tamamla.");
            if (Console.ReadLine() == "1")
            {
                Console.WriteLine("Alışverişe devam ediliyor.\n");

                return true;
            }
            else
            {
                Console.WriteLine("Alışverişi tamamla, iyi günler.\n");
                return false;
            }
        }
        else
        {
            Console.WriteLine("Alışverişe devam ediliyor.\n");
            return true;
        }


    }


    //static void Main(string[] args)
    //{
    //    Basket basket = new Basket();

    //    //Bread ekmek = new Bread(BreadType.Kepek);  
    //    //Bread ekmek1 = new Bread(BreadType.AltinEkmek);

    //    //basket.Add(ekmek);
    //    //basket.Add(ekmek1);

    //    //Console.WriteLine("Toplam fiyat(KDV hariç): "+ basket.TotalPrice());
    //    //Console.WriteLine("Toplam fiyat(KDV dahil): "+ basket.TotalPriceWithKDV());
    //    //Console.WriteLine("Sipariş KDV toplamı: " + (basket.TotalPriceWithKDV() - basket.TotalPrice()));

    //    Yogurt yogurt = new Yogurt(new DateTime(2023, 10, 11), new DateTime(2022, 12, 11), 0.5, 40, "İçim", true, Fat.HalfFat);
    //    basket.Add(yogurt);
    //    StringBuilder builder = new StringBuilder();
    //    builder.AppendLine("Üretim Tarihi ");
    //    builder.AppendLine(yogurt.ProductionDate.ToString());
    //    builder.AppendLine("Son Kullanma Tarihi ");
    //    builder.AppendLine(yogurt.ExpDate.ToString());
    //    Console.WriteLine(builder.ToString());

    //    Console.WriteLine("Cope atilabilir mi: " + yogurt.CopeAt());
    //    Console.WriteLine("Kupon kullanilabilir mi: " + yogurt.KuponKullanilabilirligi());
    //    //Console.WriteLine((DateTime.Now - new DateTime(2022, 12, 11)).TotalDays == 5);

    //}


}
