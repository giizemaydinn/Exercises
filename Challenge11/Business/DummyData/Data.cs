using Business.User;
using System.Collections.Generic;
using System.Linq;

namespace Business.DummyData
{
    public static class Data
    {
        private static int id = 0;
        public static List<Country> countries;
        public static List<City> cities;
        public static List<User.User> users;
        public static List<UserAddress> addresses;
        public static List<Phone> phones;
        static Data()
        {
            countries = new List<Country>();
            cities = new List<City>();
            users = new List<User.User>();
            addresses= new List<UserAddress>();
            phones = new List<Phone>();

            countries.Add(new Country(id++, "Hollanda"));
            countries.Add(new Country(id++, "Kanada"));
            countries.Add(new Country(id++, "Almanya"));
            countries.Add(new Country(id++, "Türkiye"));
            countries.Add(new Country(id++, "Belçika"));
            countries.Add(new Country(id++, "Brezilya"));

            cities.Add(new City(id++, "İstanbul", true));
            cities.Add(new City(id++, "Kocaeli", true));
            cities.Add(new City(id++, "Bursa", true));
            cities.Add(new City(id++, "Bolu", true));
            cities.Add(new City(id++, "Çanakkale", true));
            cities.Add(new City(id++, "İzmir", true));

            Phone phone = new Phone("Cep1", "1111111", Base.PhoneType.Home);
            Phone phone1 = new Phone("Cep2", "1111111", Base.PhoneType.Home);
            phones.Add(phone);
            phones.Add(phone1);
            UserAddress userAddress = new UserAddress("Ev", "adres aciklamas1", countries.ElementAt(3), cities.ElementAt(0), "0000", phone );
            addresses.Add(userAddress);
            userAddress.Phones.Add(phone1);
            users.Add(new User.User("uname1", "pwd1"));
            users.Last().AddAddress(userAddress);
            users.Add(new User.User("uname2", "pwd2"));
            users.Last().AddAddress(userAddress);

        }

        public static int GetId()
        {
            return id++;
        }
    }
}
