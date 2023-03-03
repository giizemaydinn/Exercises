using Business.Base;
using Business.DummyData;
using System;
using System.Collections.Generic;

namespace Business.User
{
    public class UserAddress : IBase, IActivity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public Country Country { get; set; }
        public City City { get; set; }
        public string PostalCode { get; set; }
        public List<Phone> Phones { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }

        UserAddress() 
        {
            Phones = new List<Phone>();
        }
        public UserAddress(string name, string addressLine1,  Country country, City city, string postalCode, Phone phone, string addressLine2 = "") : this()
        {
            ID = Data.GetId();
            Name = name;
            AddressLine1 = addressLine1;
            AddressLine2 = addressLine2;
            Country = country;
            City = city;
            PostalCode = postalCode;
            Phones.Add(phone);
            CreatedAt = DateTime.Now;
            IsActive = true;
        }
    }
}
