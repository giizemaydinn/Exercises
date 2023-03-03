using System.Collections;

class Program
{
    public static void Main(string[] args)
    {
        // Collections
        //      NonGeneric
        //      Generic

        // Array'ler uzerine insaa edilmistir.

        #region NonGeneric

        //  Farkli turlerdeki verilerin tutulmasini saglar.
        //  boxing - unboxing islemiyle calisirlar.

        // --> ArrayList, HashTable, SortedList

        #region ArrayList

        ArrayList Cities = new ArrayList();
        //Capacity degeri doldukca 2 kat olarak artmaktadir. 

        Array array = Array.CreateInstance(typeof(int), 10);

        // array'e donusturme
        object[] cities1 = Cities.ToArray();

        #endregion

        #region HashTable

        Hashtable siniflar = new Hashtable();
        siniflar.Add("001", "Sistem ve Ağ Uzmanlığı");
        siniflar.Add("002", "Yazılım ve Veritabanı Uzmanlığı");
        siniflar.Add("003", "Web Yazılım Uzmanlığı");

        // Son giren ilk cikar.
        foreach (var sinif in siniflar)
        {
            Console.WriteLine(sinif);
        }

        foreach (DictionaryEntry sinif in siniflar)
        {
            Console.WriteLine(sinif.Key);
        }

        #endregion

        #endregion

        #region Generics

        // Veriler belli turde alınırlar. 
        // NonGeneric'lere gore daha performanslidir (boxing - unboxing kullanmadigindan).

        // --> List, Stack, Queue, LinkedList, Dictionary, SortedDictionary, SortedSet, HashSet

        #region List

        List<string> languages = new List<string>();

        #endregion

        #region Dictionary

        Dictionary<int, string> Users = new Dictionary<int, string>();
        Users.Add(2, "User2");
        Users.Add(4, "User4");

        Console.WriteLine();

        foreach (var k in Users)
        {
            Console.WriteLine(k);
            Console.WriteLine(k.Key);
            Console.WriteLine(k.Value);
        }
        Console.WriteLine();

        foreach (KeyValuePair<int, string> p in Users)
        {
            Console.WriteLine(p.Value + " " + p.Key);
        }

        KeyValuePair<int, string> user = Users.First();

        // Dictionary yapisini List'e donusturme
        List<string> userList = Users.Values.ToList();


        #endregion

        #endregion

    }

}
