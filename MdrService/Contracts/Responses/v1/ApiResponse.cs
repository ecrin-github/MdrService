namespace MdrService.Contracts.Responses.v1;

public class ApiResponse<T> : BaseResponse<T>
{
    public int? Size { get; set; } = 10;
    public int? Page { get; set; } = 1;
    public int StatusCode { get; set; } = 200;
    public string Message { get; set; } = string.Empty;
}