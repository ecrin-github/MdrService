namespace MdrService.Contracts.Requests.Elasticsearch.v1;

public class SpecificStudyEsRequest : BaseQueryEsRequest
{
    public int SearchType { get; set; } = 13;
    public string SearchValue { get; set; } = string.Empty;
}