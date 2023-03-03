namespace Challenge05.Frontend
{

    /// <summary>
    /// Musterinin sepetinde yapabilecegi islemler burada bulunur.
    /// </summary>
    public partial interface IBasketBusiness
    {
        public void Add();

        /// <summary>
        /// Musteri siparisi tamamlamak icin kullanir. 
        /// İcerisinde diger fonksiyonlar cagirilarak kontrol yapilir.
        /// </summary>
        public void CompleteOrder();
        public void ConfirmCart();

        /// <summary>
        /// Siparis ozeti yazdirilacak 
        /// (urun toplami, kargo, indirim - indirime varsa kargo indirimi dahil edilecek.)
        /// </summary>
        public void OrderSummary();
        public void CalculateCoupon();
        public void CalculateCargoPrice();

        /// <summary>
        /// Toplam fiyat, minimum fiyattan dusukse alisverise izin vermez
        /// </summary>
        /// <returns></returns>
        public bool MinPrice();

        /// <summary>
        /// Min tutardan dusukse uyari verecek, (alisverise devam/uygulamadan cik)
        /// </summary>
        public void WarningMinPrice();
    }
    
}
