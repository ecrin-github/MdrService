using Nest;

namespace MdrService.Models.Object;

public class DataObject
{
    [Number(Name = "id")] public int? Id { get; set; }

    [Text(Name = "doi")] public string? Doi { get; set; }

    [Text(Name = "display_title")] public string? DisplayTitle { get; set; }

    [Text(Name = "version")] public string? Version { get; set; }

    [Object]
    [PropertyName("object_class")]
    public ObjectClass? ObjectClass { get; set; }

    [Object] [PropertyName("object_type")] public ObjectType? ObjectType { get; set; }

    [Date(Name = "publication_year", Format = "YYYY")]
    public int? PublicationYear { get; set; }

    [Text(Name = "lang_code")] public string? LangCode { get; set; }

    [Object]
    [PropertyName("managing_organisation")]
    public ManagingOrg? ManagingOrganisation { get; set; }

    [Object] [PropertyName("access_type")] public AccessType? AccessType { get; set; }

    [Object]
    [PropertyName("access_details")]
    public AccessDetails? AccessDetails { get; set; }

    [Number(Name = "eosc_category")]
    public int? EoscCategory { get; set; }

    [Object]
    [PropertyName("dataset_record_keys")]
    public DatasetRecordKeys? DatasetRecordKeys { get; set; }

    [Object]
    [PropertyName("dataset_deident_level")]
    public DatasetDeidentLevel? DatasetDeidentLevel { get; set; }

    [Object]
    [PropertyName("dataset_consent")]
    public DatasetConsent? DatasetConsent { get; set; }

    [Nested]
    [PropertyName("object_instances")]
    public ObjectInstance[]? ObjectInstances { get; set; }

    [Nested]
    [PropertyName("object_titles")]
    public ObjectTitle[]? ObjectTitles { get; set; }

    [Nested]
    [PropertyName("object_dates")]
    public ObjectDate[]? ObjectDates { get; set; }

    [Nested]
    [PropertyName("object_contributors")]
    public ObjectContributor[]? ObjectContributors { get; set; }

    [Nested]
    [PropertyName("object_topics")]
    public ObjectTopic[]? ObjectTopics { get; set; }

    [Nested]
    [PropertyName("object_identifiers")]
    public ObjectIdentifier[]? ObjectIdentifiers { get; set; }

    [Nested]
    [PropertyName("object_descriptions")]
    public ObjectDescription[]? ObjectDescriptions { get; set; }

    [Nested]
    [PropertyName("object_rights")]
    public ObjectRight[]? ObjectRights { get; set; }

    [Nested]
    [PropertyName("object_relationships")]
    public ObjectRelationship[]? ObjectRelationships { get; set; }

    [Number(Name = "linked_studies")] public int[]? LinkedStudies { get; set; }

    [Text(Name = "provenance_string")] public string? ProvenanceString { get; set; }
}