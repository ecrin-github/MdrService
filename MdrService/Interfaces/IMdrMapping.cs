using MdrService.Contracts.Responses.v1.DTO.v1.ObjectListResponse;
using MdrService.Contracts.Responses.v1.DTO.v1.StudyListResponse;
using MdrService.Models.Object;
using MdrService.Models.Study;

namespace MdrService.Interfaces;

public interface IMdrMapping
{
    ICollection<StudyFeatureListResponse> MapStudyFeatures(ICollection<StudyFeature> studyFeatures);

    ICollection<StudyIdentifierListResponse> MapStudyIdentifiers(ICollection<StudyIdentifier> studyIdentifiers);

    ICollection<StudyRelationListResponse> MapStudyRelationships(ICollection<StudyRelation> studyRelationships);

    ICollection<StudyTitleListResponse> MapStudyTitles(ICollection<StudyTitle> studyTitles);

    ICollection<StudyTopicListResponse> MapStudyTopics(ICollection<StudyTopic> studyTopics);


    // Object mappers
    ICollection<ObjectContributorListResponse> MapObjectContributors(ICollection<ObjectContributor> objectContributors);

    Contracts.Responses.v1.DTO.v1.Common.DatasetRecordKeys MapDatasetRecordKeys(DatasetRecordKeys datasetRecordKeys);

    Contracts.Responses.v1.DTO.v1.Common.DatasetDeidentLevel MapDatasetDeidentLevel(DatasetDeidentLevel datasetDeidentLevel);

    Contracts.Responses.v1.DTO.v1.Common.DatasetConsent MapDatasetConsent(DatasetConsent datasetConsent);

    ICollection<ObjectDateListResponse> MapObjectDates(ICollection<ObjectDate> objectDates);

    ICollection<ObjectDescriptionListResponse> MapObjectDescriptions(ICollection<ObjectDescription> objectDescriptions);

    ICollection<ObjectIdentifierListResponse> MapObjectIdentifiers(ICollection<ObjectIdentifier> objectIdentifiers);

    ICollection<ObjectInstanceListResponse> MapObjectInstances(ICollection<ObjectInstance> objectInstances);

    ICollection<ObjectRelationshipListResponse> MapObjectRelationships(ICollection<ObjectRelationship> objectRelationships);

    ICollection<ObjectRightListResponse> MapObjectRights(ICollection<ObjectRight> objectRights);

    ICollection<ObjectTitleListResponse> MapObjectTitles(ICollection<ObjectTitle> objectTitles);

    ICollection<ObjectTopicListResponse> MapObjectTopics(ICollection<ObjectTopic> objectTopics);
    
    
    ObjectListResponse BuildElasticsearchObjectResponse(DataObject dataObject);
    ICollection<ObjectListResponse> BuildElasticsearchObjectListResponse(ICollection<DataObject> dataObjects);

    StudyListResponse BuildElasticsearchStudyResponse(Study study);
    ICollection<StudyListResponse> BuildElasticsearchStudyListResponse(ICollection<Study> studies);
}