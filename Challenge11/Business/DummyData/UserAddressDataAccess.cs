using Business.Base;
using Business.User;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Business.DummyData
{
    public static class UserAddressDataAccess
    {
        public static UserAddress GetById(int id)
        {
            foreach (var item in Data.addresses)
            {
                if (item.ID == id && item.IsActive)
                {
                    return item;
                }
            }

            return null;
        }

        public static Phone GetPhoneById(int id)
        {
            foreach (var item in Data.phones)
            {
                if (item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }
        public static List<UserAddress> GetAll()
        {
            return Data.addresses;
        }

        public static UserAddress EditAddress(int addressId, string addressName, 
            int countryId, int cityId, string pCode, 
            string addressLine1, string addressLine2)
        {
            UserAddress ua = Data.addresses.SingleOrDefault(x => x.ID == addressId);
            ua.Name= addressName;
            ua.Country = Data.countries.SingleOrDefault(x => x.ID == countryId);
            ua.City = Data.cities.SingleOrDefault(x => x.ID == cityId);
            ua.PostalCode = pCode;
            ua.AddressLine1 = addressLine1;
            ua.AddressLine2 = addressLine2;

            Console.WriteLine(Data.addresses.Count);
            return ua;
        }

        public static void EditPhone(int id, string name, string phoneNumber, PhoneType type)
        {
            Phone phone = Data.phones.SingleOrDefault(x => x.ID == id);
            phone.Name = name;
            phone.PhoneNumber = phoneNumber;
            phone.Type = type;
           
        }
    }
}
