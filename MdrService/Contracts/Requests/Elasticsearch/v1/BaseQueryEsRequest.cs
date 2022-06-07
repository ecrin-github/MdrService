namespace MdrService.Contracts.Requests.Elasticsearch.v1;

public class BaseQueryEsRequest
{
    public int? Page { get; set; } = 1;
    public int? Size { get; set; } = 10;
    public object[]? Filters { get; set; } = Array.Empty<object>();
}