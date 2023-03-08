namespace Challenge16Business.Responses
{
    public class Response : IResponse
    {
        public Response(bool isSuccess, string message, int statusCode)
        {
            IsSuccess = isSuccess;
            Message = message;
            StatusCode = statusCode;
        }

        public bool IsSuccess { get; }

        public string Message { get; }

        public int StatusCode { get; }
    }
}
