namespace MdrService.Contracts.Requests.Elasticsearch.v1;

public class StudyCharacteristicsEsRequest : BaseQueryEsRequest
{
    public string TitleContains { get; set; } = string.Empty;
    public string LogicalOperator { get; set; } = "and";
    public string TopicsInclude { get; set; } = string.Empty;
}