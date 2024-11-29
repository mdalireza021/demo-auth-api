namespace demo_auth_api.Controllers
{
    public class ApiResponse<T>(T? data, string? message = null, List<string>? errorList = null)
    {
        public T? Data { get; set; } = data;
        public string? Message { get; set; } = message;
        public List<string>? ErrorList { get; set; } = errorList;
    }
}