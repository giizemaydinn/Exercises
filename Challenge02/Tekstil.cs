namespace Challenge02
{
    public enum TekstilMarka
    {
        Kigili = 1,
        Beymen = 2,
        PierreCarden = 3,
        AltinYildiz = 4,
        Polo = 5
    }
    internal class Tekstil : Product
    {
        public string Tur { get; set; }
        public int Beden { get; set; }
        public string Uretici { get; set; }
        public TekstilMarka Marka { get; set; }

        public override double SetKdv()
        {
            return Price * 1.08;
        }

        public static List<Tekstil> SearchByBrand(TekstilMarka marka)
        {
            #region Dummy Data
            List<Tekstil> textileProducts = new List<Tekstil>();

            textileProducts.Add(new Tekstil()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TekstilMarka.Beymen
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Ceket",
                Beden = 40,
                Price = 80,
                Marka = TekstilMarka.AltinYildiz
            });

            textileProducts.Add(new Tekstil()
            {
                ProductName = "Kemer",
                Beden = 40,
                Price = 40,
                Marka = TekstilMarka.PierreCarden
            });

            textileProducts.Add(new Tekstil()
            {
                ProductName = "Gömlek",
                Beden = 40,
                Price = 120,
                Marka = TekstilMarka.AltinYildiz
            });


            #endregion

            List<Tekstil> data = new List<Tekstil>();

            foreach (var t in textileProducts)
            {
                if (t.Marka == marka)
                {
                    data.Add(t);
                }
            }

            return data;

        }

        public static List<Tekstil> SearchByProductName(string pname)
        {
            #region Dummy Data
            List<Tekstil> textileProducts = new List<Tekstil>();

            textileProducts.Add(new Tekstil()
            {
                ProductName = "Pantolon",
                Beden = 40,
                Price = 100,
                Marka = TekstilMarka.Beymen
            });
            textileProducts.Add(new Tekstil()
            {
                ProductName = "Ceket",
                Beden = 40,
                Price = 80,
                Marka = TekstilMarka.AltinYildiz
            });

            textileProducts.Add(new Tekstil()
            {
                ProductName = "Kemer",
                Beden = 40,
                Price = 40,
                Marka = TekstilMarka.PierreCarden
            });

            textileProducts.Add(new Tekstil()
            {
                ProductName = "Gömlek",
                Beden = 40,
                Price = 120,
                Marka = TekstilMarka.AltinYildiz
            });


            #endregion

            List<Tekstil> data = new List<Tekstil>();

            foreach (var t in textileProducts)
            {
                if (t.ProductName.Contains(pname))
                {
                    data.Add(t);
                }
            }

            return data;

        }
    }
}
