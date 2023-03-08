namespace Challenge16Business.Responses
{
    public interface IResponse
    {
        bool IsSuccess { get; }
        string Message { get; }
        int StatusCode { get; }
    }
}
