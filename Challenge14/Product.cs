namespace Challenge14
{
    internal class Product
    {
        public int ProductId { get; set; }
        public int CategoryId { get; set; }
        public int? SubCategoryId { get; set; }
        public string ProductImageUri { get; set; }
        public string ProductTitle { get; set; }
        public string ProductPrice { get; set; }
        public string ProductUri { get; set; }
    }
}