using System;

namespace Challenge12.Entities
{
    public class ProductDto : IEntity
    {
        public int ProductID { get; set; }
        public string? ProductName { get; set; }
        public string? CompanyNameOfSupplier { get; set; }
        public string? CategoryName { get; set; }
        public string? QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public Int16? UnitsInStock { get; set; }
        public Int16? UnitsOnOrder { get; set; }
        public Int16? ReorderLevel { get; set; }
        public bool? Discontinued { get; set; }
    }
}
