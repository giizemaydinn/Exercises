using System;

namespace Challenge12.Entities
{
    public class OrderDto : IEntity
    {
        public int OrderID { get; set; }
        public string? CompanyNameofCustomer { get; set; } = string.Empty;
        public string? EmployeeName { get; set; } = string.Empty;
        public DateTime? OrderDate { get; set; } = DateTime.Now;
        public DateTime? RequiredDate { get; set; } = DateTime.Now;
        public DateTime? ShippedDate { get; set; } = DateTime.Now;
        public int? ShipVia { get; set; } = default;
        public decimal? Freight { get; set; } = default;
        public string? ShipName { get; set; } = string.Empty;
        public string? ShipAddress { get; set; } = string.Empty;
        public string? ShipCity { get; set; } = string.Empty;
        public string? ShipRegion { get; set; } = string.Empty;
        public string? ShipPostalCode { get; set; } = string.Empty;
        public string? ShipCountry { get; set; } = string.Empty;
    }
}
