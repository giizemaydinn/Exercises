using Challenge02;
using System.Text;

/// <summary>
/// Isterler 
///     Derste hazirlanan class'larin gelistirilmesi,
///     Min 3 override metot,
///     İkiden fazla ctor.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Basket basket = new Basket();

        //Bread ekmek = new Bread(BreadType.Kepek);  
        //Bread ekmek1 = new Bread(BreadType.AltinEkmek);

        //basket.Add(ekmek);
        //basket.Add(ekmek1);

        //Console.WriteLine("Toplam fiyat(KDV hariç): "+ basket.TotalPrice());
        //Console.WriteLine("Toplam fiyat(KDV dahil): "+ basket.TotalPriceWithKDV());
        //Console.WriteLine("Sipariş KDV toplamı: " + (basket.TotalPriceWithKDV() - basket.TotalPrice()));

        Yogurt yogurt = new Yogurt(new DateTime(2023, 10, 11), new DateTime(2022, 12, 11), 0.5, 40, "İçim", true, Fat.HalfFat);
        basket.Add(yogurt);
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("Üretim Tarihi ");
        builder.AppendLine(yogurt.ProductionDate.ToString());
        builder.AppendLine("Son Kullanma Tarihi ");
        builder.AppendLine(yogurt.ExpDate.ToString());
        Console.WriteLine(builder.ToString());

        Console.WriteLine("Cope atilabilir mi: " + yogurt.CopeAt());
        Console.WriteLine("Kupon kullanilabilir mi: " + yogurt.KuponKullanilabilirligi());
        //Console.WriteLine((DateTime.Now - new DateTime(2022, 12, 11)).TotalDays == 5);

    }
}
