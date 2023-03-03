class Program
{
    /// <summary>
    /// params keyword.
    /// </summary>
    /// <param name="args"></param>
    public static void Main(string[] args)
    {
        EnBuyuk(1, 2, 3);
        EnBuyukWithArray(data: new int[] { 1, 2, 3 }); // params vs array parameter

    }

    /// <summary>
    /// İstediğim kadar int parametre göndereyim, ve en büyüğü dönsün.
    /// Çözüm : Variadic Parameters (Değişken Sayıda Parametre)
    /// </summary>
    /// <returns></returns>
    static int EnBuyuk(params int[] data)
    {
        Console.WriteLine("params : " + data);
        return 0;
    }

    static int EnBuyukWithArray(int[] data)
    {
        Console.WriteLine("params : " + data);
        return 0;
    }

    
  
}
