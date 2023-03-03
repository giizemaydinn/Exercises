using Challenge03;

class Program
{
    /// <summary>
    /// Static class
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        User k = new User();
        k.Ad = "Test";
        User k1 = new User();
        k1.Ad = "Test1";
        //k.PrivateID = 1 ;
        //Console.WriteLine(Kullanici.ID);
        Database.Add(k1);

    }
}
