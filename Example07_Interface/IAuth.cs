namespace Example07_Interface
{
    interface IAuth
    {
        int AuthId { get; set; }
        int UserId { get; set; }
        void Authorize(int userId, int authId);
        void DeleteAuth(int userId, int authId);
    }
}
