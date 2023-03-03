class Kutu
{
    // Field (Alan)
    private double uzunluk;
    private double genislik;
    private double yukseklik;
    private Guid guid;

    // Constructor 
    public Kutu()
    {
        Console.WriteLine("Sınıf kuruldu.");
        guid = Guid.NewGuid();
    }

    // Constructor Overload
    public Kutu(double uzunluk, double genislik, double yukseklik)
    {
        this.uzunluk = uzunluk;
        this.genislik = genislik;
        this.yukseklik = yukseklik;
    }

    // Destructor
    ~Kutu()
    {
        // GC - Garbage Collector

    }

    // Encapsulation

    // Yöntem 1 : Getter & Setter
    // Yöntem 2 : Properties

    #region Getter & Setter Methods

    public double GetUzunluk()  // Getter
    {
        return uzunluk;
    }

    public void SetUzunluk(double uzunluk)
    {
        if (uzunluk >= 2)
        {
            // Name Hiding
            this.uzunluk = uzunluk;
        }
        else
        {
            this.uzunluk = 0;
        }
    }

    #endregion

    #region Property

    public double Genislik
    {
        get { return genislik; }
        set { genislik = value; }
    }

    //public double Genislik
    //{
    //    get
    //    {
    //        return genislik;
    //    }
    //    set
    //    {
    //        genislik = value;
    //    }
    //}

    //public double Genislik
    //{
    //    get
    //    {
    //        return genislik;
    //    }
    //    set
    //    {
    //        if (value >= 2)
    //        {
    //            genislik = value;
    //        }
    //        else
    //        {
    //            genislik = 0;
    //        }
    //    }
    //}

    #endregion

    // Get My Guid

    public void GetMyGuid()
    {
        guid = Guid.NewGuid();
        Console.WriteLine(guid.ToString());
    }
}