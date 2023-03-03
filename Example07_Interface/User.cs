namespace Example07_Interface
{
    internal class User : Program, IUser, IAuth, IDisposable
    {
        public int AuthId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public int UserId { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void Add(string username, string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Authorize(int userId, int authId)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public void DeleteAuth(int userId, int authId)
        {
            throw new NotImplementedException();
        }



        public List<UserInfo> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserInfo GetById(int id)
        {
            throw new NotImplementedException();
        }

        public bool Login(string username, string password)
        {
            throw new NotImplementedException();
        }

        public void Update(int id, string username, string email, string password)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            GC.SuppressFinalize(this);
        }
    }
}
