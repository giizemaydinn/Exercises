namespace Challenge15DataAccess.Responses
{
    public interface IResponse
    {
        bool IsSuccess { get; }
        string Message { get; }
        int StatusCode { get; }
    }
}
