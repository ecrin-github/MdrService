using MdrService.Contracts.Responses.v1.DTO.v1.Common;

namespace MdrService.Contracts.Responses.v1.DTO.v1.ObjectListResponse;

public class ObjectListResponse
{
    public int? Id { get; set; }
        
    public string? Doi { get; set; }
        
    public string? DisplayTitle { get; set; }
        
    public string? Version { get; set; }
        
    public string? ObjectClass { get; set; }
        
    public string? ObjectType { get; set; }
        
    public string? ObjectUrl { get; set; }
        
    public int? PublicationYear { get; set; }
        
    public string? LangCode { get; set; }
        
    public ManagingOrg? ManagingOrganisation { get; set; }
        
    public string? AccessType { get; set; }
        
    public AccessDetails? AccessDetails { get; set; }
        
    public int? EoscCategory { get; set; } 
        
    public DatasetRecordKeys? DatasetRecordKeys { get; set; }
        
    public DatasetDeidentLevel? DatasetDeidentLevel { get; set; }
        
    public DatasetConsent? DatasetConsent { get; set; }
        
    public ObjectInstanceListResponse[]? ObjectInstances { get; set; }
        
    public ObjectTitleListResponse[]? ObjectTitles { get; set; }
        
    public ObjectDateListResponse[]? ObjectDates { get; set; }
        
    public ObjectContributorListResponse[]? ObjectContributors { get; set; }
        
    public ObjectTopicListResponse[]? ObjectTopics { get; set; }
        
    public ObjectIdentifierListResponse[]? ObjectIdentifiers { get; set; }
        
    public ObjectDescriptionListResponse[]? ObjectDescriptions { get; set; }
        
    public ObjectRightListResponse[]? ObjectRights { get; set; }
        
    public ObjectRelationshipListResponse[]? ObjectRelationships { get; set; }
        
    public int[]? LinkedStudies { get; set; }
        
    public string? ProvenanceString { get; set; }
}