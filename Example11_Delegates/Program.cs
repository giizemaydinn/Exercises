class Program
{
    /// <summary>
    /// Delegates.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        Hesap hesap = Topla;

        var x = hesap(3, 4);

        hesap = Carp;

        var y = hesap(5, 6);


        Hesap hesap1 = new Hesap(hesap);
        var x3 = hesap1.Invoke(4, 3);
        Console.WriteLine(x3);
    }

    delegate int Hesap(int x, int y);

    static int Topla(int a, int b)
    {
        return a + b;
    }

    static int Cikar(int a, int b)
    {
        return a - b;
    }

    static int Carp(int a, int b)
    {
        return a * b;
    }

    static int Bol(int a, int b)
    {
        return a / b;
    }
}