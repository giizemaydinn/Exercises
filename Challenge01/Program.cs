using Challenge01.Entities;

/// <summary>
/// Isterler -> min 2 class, uygun metotlar kullanilmali.
/// </summary>
class Program
{
    static void Main(string[] args)
    {
        Category category = new Category("Bilgisayar");
        Laptop l = new Laptop(4, "testOS", "testPT", 1, PowerSource.electric);

        Console.WriteLine(
            "id: " + l.ID + " " +
            "cat id: " + l.CategoryID + " " +
            "ram: " + l.RAM + " " +
            "guc kaynagi: " + l.PowerSource + " " +
            "işlemci: " + l.ProcessorType);
    }
}