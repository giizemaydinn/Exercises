using Business.Base;

namespace Business.User
{
    public class Country : IID, IActivity
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public bool IsActive { get; set; }

        Country() { }
        public Country(int id, string name)
        {
            ID = id;
            Name = name;
            IsActive = true;
        }
    }
}
