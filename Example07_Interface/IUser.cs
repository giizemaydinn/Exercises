namespace Example07_Interface
{
    interface IUser
    {
        void Add(string username, string email, string password);
        void Update(int id, string username, string email, string password);
        void Delete(int id);
        UserInfo GetById(int id);
        List<UserInfo> GetAll();
        bool Login(string username, string password);
    }
}
