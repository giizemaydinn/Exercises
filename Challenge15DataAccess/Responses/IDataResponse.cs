namespace Challenge15DataAccess.Responses
{
    public interface IDataResponse<T> : IResponse
    {
        T Data { get; }
    }
}
