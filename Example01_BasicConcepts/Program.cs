using System.Text;

class Program
{
    /// <summary>
    /// Temel kavramlara ait ornekler iceren proje.
    /// </summary>
    /// <param name="args"></param>
    static void Main(string[] args)
    {
        #region Degisken Kullanimi

        // Acik renk olanlar .NET framework'ten gelir.
        Int32 x = 0;
        // Koyu renkte olanlar C#'a aittir.
        // Bunlar da arkaplanda .NET framework versiyonunu isaret eder. (System.Int32)
        int x1 = 0;

        // Negatif deger kullanilmayacagi durumlar degiskenin kapasitesi arttirilabilir.
        int capacity = int.MaxValue; // 2147483647
        uint capacity1 = (uint)(capacity * 2); // 4294967295

        // Belli bir tipin default degerini almak.
        double d = default(double);
        double d1 = new double();

        // ASCII alt satir karakteri 
        Console.WriteLine(Environment.NewLine);

        // Coklu string kullanimi icin daha performansli. 
        StringBuilder builder = new StringBuilder();
        builder.AppendLine("Gizem ");
        builder.AppendLine("Aydin");

        // string bos deger olusturmak.
        string s = string.Empty;

        // value type'lar default olarak null alamazlar. “?” ile nullable yapilir.
        int? abc = null;

        // ref ornegi 
        string str = "10k";
        int result = 4;
        bool b = int.TryParse(str, out result); // eger donusturulebilirse sonuc result'a atanir.
        Console.WriteLine(b + " " + result); //false 0

        // placeholder kullanimi
        Console.WriteLine("Gonderilen deger bundan sonra yazilacak: {0}", 2); // 2

        #endregion

        #region object vs var

        // object sonradan tipi degisebilir.

        // eger var keyword'u kullanilarak bir degisken olusturulmak isteniyor ve değeri belli degilse asagidaki sek. kullanilabilir.
        var isimX = (string)null;

        // var, metotlara parametre olarak gonderilemez.
        // var, tipteki degisken initialize edilmeden kullanilamaz.
        // var, global scope'ta kullanilamaz.

        // Multiple sekilde kullanilamaz.
        /*
         * var x = 10, y = 5; 
         */
        #endregion

        #region boxing - unboxing islemi

        // Boxing ile degiskenin kopyasi olusturulur. 
        // Kopya oldugundan objedeki degisim value tipin degerini degistirmez.
        // Normal atama islemine gore cok daha yavastir.
        int i = 5;
        object obje = i;
        i = (int)obje; //unboxing

        #endregion

        #region Enum kullanimi

        // string'i enum'a donusturme
        Marka marka = (Marka)Enum.Parse(typeof(Marka), "Adidas");

        //enum ile int ve long kullanilabilir.

        #endregion

        #region Switch

        int deger = 2;
        switch (deger)
        {
            case 0: // sonrasindaki case'le ayni islem yapilmasi isteniyorsa ici bos birakilabilir.
            case 1:
                ParamRef(ref deger); //eger case'ten sonra islem yapilirsa break gelmek zorunda.
                break;
            case 2:
            default:
                break;

        }

        #endregion

        #region notes
        // anonymous methods
        #endregion
    }

    #region Enum Kullanimi
    enum Yetki
    {
        Norml = 1, //dbdeki id
        Moderator = 10,
        Editor = 13,
        Admin = 40,
        SuperAdmin = 100
    } //(int)Yetki.Normal -> 1

    public enum Marka
    {
        Adidas = 1,
        Nike = 2,
        Puma = 3
    }
    #endregion

    #region ref vs out
    //ref: aktarilirken ilk deger zorunlu.
    static void ParamRef(ref int x)
    {
        x = x * 2;
    }

    //out: sadece geriye deger dondurmek gerektiginde kullanilabilir.
    //metot sonlanmadan out parametresine deger atamak zorundayiz cunku ilk deger vermedigimiz icin herhangi bir degere
    //sahip degildir.
    static void ParamOut(out int x)
    {
        x = 2;
    }

    #endregion
}


