namespace Challenge16Business.Responses
{
    public interface IDataResponse<T> : IResponse
    {
        T Data { get; }
    }
}
