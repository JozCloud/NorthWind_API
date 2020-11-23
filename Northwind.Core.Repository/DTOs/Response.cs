namespace Northwind.Core.Repository.DTOs
{
    public class Response<T>
    {
        public bool IsSuccess { get; set; }
        public T Data { get; set; }
        public string ErrorMessage { get; set; }
    }
}