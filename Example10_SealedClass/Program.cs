class Program
{
    /// <summary>
    /// Sealed class.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {

    }
}

sealed class A
{
    public int PropA { get; set; }
}

// HATA
//class B : A
//{
//    public int PropB { get; set; }
//}