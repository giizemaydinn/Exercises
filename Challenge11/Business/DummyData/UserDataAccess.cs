using System.Collections.Generic;

namespace Business.DummyData
{
    public static class UserDataAccess
    {
        public static User.User GetById(int id)
        {
            foreach(var item in Data.users)
            {
                if(item.ID == id && item.IsActive)
                {
                    return item;
                }
            }

            return null;    
        }

        public static List<User.User> GetAll()
        {
            return Data.users;
        }

        public static User.User EditUser(User.User user)
        {
            Data.users[user.ID] = user;

            return Data.users[user.ID];
        }
    }
}
