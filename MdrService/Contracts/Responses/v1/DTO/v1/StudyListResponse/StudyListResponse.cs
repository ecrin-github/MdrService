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
    public ICollection<StudyIdentifierListResponse>? StudyIdentifiers { get; set; }
    public ICollection<StudyTitleListResponse>? StudyTitles { get; set; }
    public ICollection<StudyFeatureListResponse>? StudyFeatures { get; set; }
    public ICollection<StudyTopicListResponse>? StudyTopics { get; set; }
    public ICollection<StudyRelationListResponse>? StudyRelationships { get; set; }
    public string? ProvenanceString { get; set; }
    public ICollection<ObjectListResponse.ObjectListResponse>? LinkedDataObjects { get; set; }
}