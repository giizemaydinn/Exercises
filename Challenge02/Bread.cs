namespace Challenge02
{
    public enum BreadType
    {
        Beyaz = 1,
        Kepek = 2,
        Bugday = 3,
        Odun = 4,
        AltinEkmek = 5
    }

    public enum Gramaj
    {
        Yuz = 100,
        YuzYirmiBes = 125,
        IkiYuz = 200
    }

    //public static class Price
    //{
    //    public const double Bir = 1.0;
    //    public const double Iki = 2.0;
    //    public const double BirBucuk = 1.5;
    //}
    class Bread : Product
    {
        public BreadType Type { get; set; }
        public Gramaj Gram { get; set; }
        public string Uretici { get; set; }
        public override double SetKdv()
        {
            return Price * 1.01; ;
        }
        public Bread() { }

        public Bread(
           BreadType type)
        {

            switch (type)
            {
                case BreadType.Beyaz:
                    Price = 1.0;
                    Gram = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    Price = 1.0;
                    Gram = Gramaj.Yuz;
                    break;
                case BreadType.Bugday:
                    Price = 2.0;
                    Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    Price = 2.0;
                    Gram = Gramaj.IkiYuz;
                    break;
                case BreadType.AltinEkmek:
                    Price = 1.5;
                    Gram = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }

        public Bread(
            double price,
            BreadType type)
        {
            double _price = 0;
            if (price > 0)
            {
                _price = price;
            }
            if (_price <= 0)
            {
                throw new Exception("Ekmek ücreti sıfır ya da sıfırdan küçük olamaz.");
            }
            switch (type)
            {
                case BreadType.Beyaz:
                    Price = _price;
                    Gram = Gramaj.Yuz;
                    break;
                case BreadType.Kepek:
                    Price = _price;
                    Gram = Gramaj.Yuz;
                    break;
                case BreadType.Bugday:
                    Price = _price;
                    Gram = Gramaj.Yuz;
                    break;
                case BreadType.Odun:
                    Price = _price;
                    Gram = Gramaj.IkiYuz;
                    break;
                case BreadType.AltinEkmek:
                    Price = _price;
                    Gram = Gramaj.YuzYirmiBes;
                    break;
                default:
                    break;
            }
        }
    }
    /// <summary>
    /// Ben custom bir ucret belirleyerek X tipindeki ekmegi satiyorum.
    /// </summary>
    /// <param name="type"></param>


}
