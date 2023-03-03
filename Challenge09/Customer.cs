namespace Challenge09
{
    public class Customer
    {
        private static int ID = 5;
        public int Id { get; set; }
        public string Name { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public Customer(string name, string phoneNumber, string address)
        {
            Id = ID++;
            Name = name;
            PhoneNumber = phoneNumber;
            Address = address;
        }
    }
}
