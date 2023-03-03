using Business.Base;
using Business.DummyData;

namespace Business.User
{
    public class Phone : IID
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public PhoneType Type { get; set; }

        public Phone(string name, string phoneNumber, PhoneType type)
        {
            ID = Data.GetId();
            Name = name;
            PhoneNumber = phoneNumber;
            Type = type;
        }
    }
}
