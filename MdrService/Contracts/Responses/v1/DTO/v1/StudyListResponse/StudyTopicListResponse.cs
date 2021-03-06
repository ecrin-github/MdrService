namespace MdrService.Contracts.Responses.v1.DTO.v1.StudyListResponse;

public class StudyTopicListResponse
{
    public int? Id { get; set; }
        
    public string? TopicType { get; set; }
        
    public bool? MeshCoded { get; set; }
        
    public string? MeshCode { get; set; }
        
    public string? MeshValue { get; set; }
        
    public int? OriginalCtId { get; set; }
        
    public string? OriginalCtCode { get; set; }

    public string? OriginalValue { get; set; }
}