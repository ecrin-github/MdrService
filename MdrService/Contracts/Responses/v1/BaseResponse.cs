namespace MdrService.Contracts.Responses.v1;

public class BaseResponse<T>
{
    public int Total { get; set; } = 0;
    public ICollection<T> Data { get; set; } = Array.Empty<T>();
}