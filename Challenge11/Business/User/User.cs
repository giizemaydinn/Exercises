using Business.Base;
using Business.DummyData;
using System;
using System.Collections.Generic;

namespace Business.User
{
    public class User : IBase, IActivity
    {
        public int ID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public List<UserAddress> Addresses { get; set; } = new List<UserAddress>();
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public bool IsActive { get; set; }

        User() 
        {
            Addresses = new List<UserAddress>();    
        }
        public User(string uname, string pwd) : this()
        {
            this.ID = Data.GetId();
            this.Username = uname;
            this.Password = pwd;
            this.CreatedAt= DateTime.Now;
            this.IsActive= true;
        }

        public void AddAddress(UserAddress userAddress)
        {
            this.Addresses.Add(userAddress);
        }

        public User GetById(int id)
        {
            foreach(var item in Data.users)
            {
                if(item.ID == id)
                {
                    return item;
                }
            }

            return null;
        }
        public override string ToString()
        {
            return this.Firstname + " " + this.Lastname;
        }

    }
}
