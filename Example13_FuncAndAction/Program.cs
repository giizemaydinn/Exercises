class Program
{
    // Func & Action
    // Delegate'lerdir.
    static void Main(string[] args)
    {
        #region Action

        // Geriye deger dondurmeyen metotlar icin kullanilir.
        //delegate'in gereiye deger dondurmeyen versiyonudur.
        Action<int, string> action = new Action<int, string>(KullaniciBilgi);
        action(10, "Gizem Aydın");

        #endregion

        #region Func

        //Geriye deger donduren bir delegate versiyonudur.
        Func<DateTime, double> func = new Func<DateTime, double>(GetUserAgeAtTime);
        var bDate = new DateTime(1999, 02, 17);
        double dateDiff = func(bDate);
        Console.WriteLine(dateDiff + " gundur yasıyorsunuz.");

        #endregion
    }

    static void KullaniciBilgi(int kullaniciId, string adSoyad)
    {
        Console.WriteLine("Kullanici ID: " + kullaniciId);
    }

    static double GetUserAgeAtTime(DateTime date)
    {
        return (DateTime.Now - date).TotalDays;
    }
}
