namespace Challenge16Business.Responses
{
    public class DataResponse<T> : Response, IDataResponse<T>
    {
        public DataResponse(T data, bool isSuccess, string message, int statusCode) : base(isSuccess, message, statusCode)
        {
            Data = data;
        }

        public T Data { get; }
    }
}
