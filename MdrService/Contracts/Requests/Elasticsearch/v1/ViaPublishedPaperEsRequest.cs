namespace MdrService.Contracts.Requests.Elasticsearch.v1;

public class ViaPublishedPaperEsRequest : BaseQueryEsRequest
{
    public string SearchType { get; set; } = "title";
    public string SearchValue { get; set; } = string.Empty;
}