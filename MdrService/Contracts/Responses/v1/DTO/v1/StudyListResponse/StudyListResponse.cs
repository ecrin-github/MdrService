namespace MdrService.Contracts.Responses.v1.DTO.v1.StudyListResponse;

public class StudyListResponse
{
    public int? Id { get; set; }
    public string? DisplayTitle { get; set; }
    public string? BriefDescription { get; set; }
    public string? StudyType { get; set; }
    public string? StudyStatus { get; set; }
    public string? StudyGenderElig { get; set; }
    public string? StudyEnrolment { get; set; }
    public AgeResponse? MinAge { get; set; }
    public AgeResponse? MaxAge { get; set; }
    public StudyIdentifierListResponse[]? StudyIdentifiers { get; set; }
    public StudyTitleListResponse[]? StudyTitles { get; set; }
    public StudyFeatureListResponse[]? StudyFeatures { get; set; }
    public StudyTopicListResponse[]? StudyTopics { get; set; }
    public StudyRelationListResponse[]? StudyRelationships { get; set; }
    public string? ProvenanceString { get; set; }
    public ObjectListResponse.ObjectListResponse[]? LinkedDataObjects { get; set; }
}