namespace Challenge02
{
    enum Fat
    {
        WholeFat = 0,
        NonFat = 1,
        HalfFat = 2
    }
    internal class Yogurt : Product
    {
        public DateTime ProductionDate { get; set; }
        public DateTime ExpDate { get; set; }
        public double Capacity { get; set; }
        public double Calory { get; set; }
        public string Brand { get; set; }
        public bool LactoseFree { get; set; }
        public bool WithCreamy { get; set; }
        public bool Recyclability { get; set; }
        //Meyveli vs. gibi ekstra ozellikler icin kullanilabilir.
        public List<string> contents { get; set; }
        public Fat fat { get; set; }

        /// <summary>
        /// Icerik listesi new'lendi. 
        /// Public yapilmayarak bos ctor kullanimi engellendi.
        /// </summary>
        Yogurt()
        {
            contents = new List<string>();
        }
        /// <summary>
        /// Tarih kontrolu yapmak icin kullanilir.
        /// </summary>
        /// <param name="ProductionDate"></param>
        /// <param name="ExpDate"></param>
        /// <exception cref="Exception"></exception>
        Yogurt(DateTime ProductionDate, DateTime ExpDate) : this()
        {
            if (IsOutOfDate())
                throw new Exception("Tarihi gecmis urun sepete eklenemez.");
            this.ProductionDate = ProductionDate;
            this.ExpDate = ExpDate;

        }
        /// <summary>
        /// Laktoz, kaymak ve icerik bilgileri opsiyonel olarak birakilmistir.
        /// Tarih kontrolu icin diger ctor cagirilmistir.
        /// Gecersiz kapasite girilmesi engellenmistir.
        /// </summary>
        /// <param name="productionDate"> </param>
        /// <param name="expDate"></param>
        /// <param name="capacity"></param>
        /// <param name="calory"></param>
        /// <param name="brand"></param>
        /// <param name="containerType"></param>
        /// <param name="lactoseFree"></param>
        /// <param name="withCreamy"></param>
        /// <param name="contents"></param>
        public Yogurt(
            DateTime productionDate,
            DateTime expDate,
            double capacity,
            double calory,
            string brand,
            bool recyclability,
            Fat fat,
            bool lactoseFree = false,
            bool withCreamy = false,
            List<string> contents = default) : this(productionDate, expDate)
        {
            if (capacity < 0)
                throw new Exception("Gecersiz deger girilmistir.");
            if (calory < 0)
                throw new Exception("Gecersiz deger girilmistir.");

            Capacity = capacity;
            Calory = calory;
            Brand = brand;
            LactoseFree = lactoseFree;
            WithCreamy = withCreamy;
            this.contents = contents;
            this.fat = fat;
            Recyclability = recyclability;
            Console.WriteLine("Yogurt olusturuldu.");

        }

        /// <summary>
        /// Tarihi gecmisse true deger dondurur.
        /// </summary>
        /// <returns></returns>
        public bool IsOutOfDate()
        {
            return DateTime.Now < ExpDate;
        }

        /// <summary>
        /// Geri donusume gonderilebilenler cope atilamaz.
        /// </summary>
        /// <returns></returns>
        public override bool CopeAt()
        {
            if (Recyclability) return false;
            return true;
        }

        /// <summary>
        /// Belli urunler belli kurallar cercevesinde adet siniri getirilsin.
        /// </summary>
        /// <returns></returns>
        public override bool AdetKontrolu()
        {
            return false;
        }

        /// <summary>
        /// Son kullanma tarihine 15'ten az varsa kupon kullanilabilir.
        /// </summary>
        /// <returns></returns>
        public override bool KuponKullanilabilirligi()
        {
            //TimeSpan ts = DateTime.Now.Ticks - ExpDate;
            //if(ts < TimeSpan.Compare(15))
            //{

            //}
            int days = (int)(DateTime.Now - ExpDate).TotalDays;
            if (days < 15 && days > 0)
                return true;
            return false;
        }
    }
}
