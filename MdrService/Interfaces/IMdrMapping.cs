using MdrService.Contracts.Responses.v1.DTO.v1.ObjectListResponse;
using MdrService.Contracts.Responses.v1.DTO.v1.StudyListResponse;
using MdrService.Models.Object;
using MdrService.Models.Study;

namespace MdrService.Interfaces;

public interface IMdrMapping
{
    StudyFeatureListResponse[] MapStudyFeatures(StudyFeature[] studyFeatures);

    StudyIdentifierListResponse[] MapStudyIdentifiers(StudyIdentifier[] studyIdentifiers);

    StudyRelationListResponse[] MapStudyRelationships(StudyRelation[] studyRelationships);

    StudyTitleListResponse[] MapStudyTitles(StudyTitle[] studyTitles);

    StudyTopicListResponse[] MapStudyTopics(StudyTopic[] studyTopics);


    // Object mappers
    ObjectContributorListResponse[] MapObjectContributors(ObjectContributor[] objectContributors);

    Contracts.Responses.v1.DTO.v1.Common.DatasetRecordKeys MapDatasetRecordKeys(DatasetRecordKeys datasetRecordKeys);

    Contracts.Responses.v1.DTO.v1.Common.DatasetDeidentLevel MapDatasetDeidentLevel(DatasetDeidentLevel datasetDeidentLevel);

    Contracts.Responses.v1.DTO.v1.Common.DatasetConsent MapDatasetConsent(DatasetConsent datasetConsent);

    ObjectDateListResponse[] MapObjectDates(ObjectDate[] objectDates);

    ObjectDescriptionListResponse[] MapObjectDescriptions(ObjectDescription[] objectDescriptions);

    ObjectIdentifierListResponse[] MapObjectIdentifiers(ObjectIdentifier[] objectIdentifiers);

    ObjectInstanceListResponse[] MapObjectInstances(ObjectInstance[] objectInstances);

    ObjectRelationshipListResponse[] MapObjectRelationships(ObjectRelationship[] objectRelationships);

    ObjectRightListResponse[] MapObjectRights(ObjectRight[] objectRights);

    ObjectTitleListResponse[] MapObjectTitles(ObjectTitle[] objectTitles);

    ObjectTopicListResponse[] MapObjectTopics(ObjectTopic[] objectTopics);
    
    
    ObjectListResponse BuildElasticsearchObjectResponse(DataObject dataObject);
    ObjectListResponse[] BuildElasticsearchObjectListResponse(DataObject[] dataObjects);

    StudyListResponse BuildElasticsearchStudyResponse(Study study);
    StudyListResponse[] BuildElasticsearchStudyListResponse(Study[] studies);
}