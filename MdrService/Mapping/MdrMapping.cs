using MdrService.Contracts.Responses.v1.DTO.v1.Common;
using MdrService.Contracts.Responses.v1.DTO.v1.ObjectListResponse;
using MdrService.Contracts.Responses.v1.DTO.v1.StudyListResponse;
using MdrService.Interfaces;
using MdrService.Models.Object;
using MdrService.Models.Study;
using DatasetConsent = MdrService.Models.Object.DatasetConsent;
using DatasetDeidentLevel = MdrService.Models.Object.DatasetDeidentLevel;
using DatasetRecordKeys = MdrService.Models.Object.DatasetRecordKeys;


namespace MdrService.Mapping;

public class MdrMapping : IMdrMapping
{
    public StudyFeatureListResponse[] MapStudyFeatures(StudyFeature[] studyFeatures)
    {
        return studyFeatures.Select(sf => new StudyFeatureListResponse
        {
            Id = sf.Id,
            FeatureType = sf.FeatureType?.Name,
            FeatureValue = sf.FeatureValue?.Name
        }).ToArray();
    }

    public StudyIdentifierListResponse[] MapStudyIdentifiers(StudyIdentifier[] studyIdentifiers)
    {
        return studyIdentifiers.Select(si => new StudyIdentifierListResponse()
            {
                Id = si.Id,
                IdentifierValue = si.IdentifierValue,
                IdentifierType = si.IdentifierType?.Name,
                IdentifierDate = si.IdentifierDate,
                IdentifierOrg = new IdentifierOrg()
                    { Id = si.IdentifierOrg?.Id, Name = si.IdentifierOrg?.Name, RorId = si.IdentifierOrg?.RorId },
                IdentifierLink = si.IdentifierLink
            })
            .ToArray();
    }

    public StudyRelationListResponse[] MapStudyRelationships(StudyRelation[] studyRelationships)
    {
        return studyRelationships.Select(sr => new StudyRelationListResponse()
            {
                Id = sr.Id, RelationshipType = sr.RelationshipType?.Name, TargetStudyId = sr.TargetStudyId.ToString()
            })
            .ToArray();
    }

    public StudyTitleListResponse[] MapStudyTitles(StudyTitle[] studyTitles)
    {
        return studyTitles.Select(st => new StudyTitleListResponse()
        {
            Id = st.Id,
            TitleText = st.TitleText,
            TitleType = st.TitleType?.Name,
            LangCode = st.LangCode,
            Comments = st.Comments
        }).ToArray();
    }

    public StudyTopicListResponse[] MapStudyTopics(StudyTopic[] studyTopics)
    {
        return studyTopics.Select(st => new StudyTopicListResponse()
        {
            Id = st.Id,
            TopicType = st.TopicType?.Name,
            MeshCode = st.MeshCode,
            MeshCoded = st.MeshCoded,
            MeshValue = st.MeshValue,
            OriginalCtId = st.OriginalCtId,
            OriginalValue = st.OriginalValue,
            OriginalCtCode = st.OriginalCtCode
        }).ToArray();
    }

    public ObjectContributorListResponse[] MapObjectContributors(ObjectContributor[] objectContributors)
    {
        return objectContributors.Select(oc => new ObjectContributorListResponse()
        {
            Id = oc.Id,
            ContributionType = oc.ContributionType?.Name,
            IsIndividual = oc.IsIndividual,
            Organisation = new Contracts.Responses.v1.DTO.v1.Common.ContribOrg
            {
                Id = oc.Organisation?.Id,
                Name = oc.Organisation?.Name,
                RorId = oc.Organisation?.RorId
            },
            Person = new Contracts.Responses.v1.DTO.v1.Common.Person
            {
                FamilyName = oc.Person?.FamilyName,
                GivenName = oc.Person?.GivenName,
                FullName = oc.Person?.FullName,
                Orcid = oc.Person?.Orcid,
                AffiliationString = oc.Person?.AffiliationString,
                AffiliationOrgId = oc.Person?.AffiliationOrgId,
                AffiliationOrgName = oc.Person?.AffiliationOrgName,
                AffiliationOrgRorId = oc.Person?.AffiliationOrgRorId
            }
        }).ToArray();
    }

    public Contracts.Responses.v1.DTO.v1.Common.DatasetRecordKeys MapDatasetRecordKeys(
        DatasetRecordKeys datasetRecordKeys)
    {
        return new Contracts.Responses.v1.DTO.v1.Common.DatasetRecordKeys()
        {
            KeysTypeId = datasetRecordKeys.KeysTypeId,
            KeysType = datasetRecordKeys.KeysType,
            KeysDetails = datasetRecordKeys.KeysDetails
        };
    }

    public Contracts.Responses.v1.DTO.v1.Common.DatasetDeidentLevel MapDatasetDeidentLevel(
        DatasetDeidentLevel datasetDeidentLevel)
    {
        return new Contracts.Responses.v1.DTO.v1.Common.DatasetDeidentLevel()
        {
            DeidentTypeId = datasetDeidentLevel.DeidentTypeId,
            DeidentType = datasetDeidentLevel.DeidentType,
            DeidentDirect = datasetDeidentLevel.DeidentDirect,
            DeidentHipaa = datasetDeidentLevel.DeidentHipaa,
            DeidentDates = datasetDeidentLevel.DeidentDates,
            DeidentNonarr = datasetDeidentLevel.DeidentNonarr,
            DeidentKanon = datasetDeidentLevel.DeidentKanon,
            DeidentDetails = datasetDeidentLevel.DeidentDetails
        };
    }

    public Contracts.Responses.v1.DTO.v1.Common.DatasetConsent MapDatasetConsent(DatasetConsent datasetConsent)
    {
        return new Contracts.Responses.v1.DTO.v1.Common.DatasetConsent()
        {
            ConsentTypeId = datasetConsent.ConsentTypeId,
            ConsentType = datasetConsent.ConsentType,
            ConsentNoncommercial = datasetConsent.ConsentNoncommercial,
            ConsentGeogRestrict = datasetConsent.ConsentGeogRestrict,
            ConsentResearchType = datasetConsent.ConsentResearchType,
            ConsentGeneticOnly = datasetConsent.ConsentGeneticOnly,
            ConsentNoMethods = datasetConsent.ConsentNoMethods,
            ConsentsDetails = datasetConsent.ConsentsDetails
        };
    }

    public ObjectDateListResponse[] MapObjectDates(ObjectDate[] objectDates)
    {
        return objectDates.Select(od => new ObjectDateListResponse()
        {
            Id = od.Id,
            DateType = od.DateType?.Name,
            DateIsRange = od.DateIsRange,
            DateAsString = od.DateAsString,
            StartDate = new Contracts.Responses.v1.DTO.v1.Common.Date
            {
                Year = od.StartDate?.Year,
                Month = od.StartDate?.Month,
                Day = od.StartDate?.Day
            },
            EndDate = new Contracts.Responses.v1.DTO.v1.Common.Date
            {
                Year = od.EndDate?.Year,
                Month = od.EndDate?.Month,
                Day = od.EndDate?.Day
            },
            Comments = od.Comments
        }).ToArray();
    }

    public ObjectDescriptionListResponse[] MapObjectDescriptions(ObjectDescription[] objectDescriptions)
    {
        return objectDescriptions.Select(od => new ObjectDescriptionListResponse()
        {
            Id = od.Id,
            DescriptionType = od.DescriptionType?.Name,
            DescriptionLabel = od.DescriptionLabel,
            DescriptionText = od.DescriptionText,
            LangCode = od.LangCode
        }).ToArray();
    }

    public ObjectIdentifierListResponse[] MapObjectIdentifiers(ObjectIdentifier[] objectIdentifiers)
    {
        return objectIdentifiers.Select(oi => new ObjectIdentifierListResponse()
        {
            Id = oi.Id,
            IdentifierValue = oi.IdentifierValue,
            IdentifierType = oi.IdentifierType?.Name,
            IdentifierDate = oi.IdentifierDate,
            IdentifierOrg = new IdentifierOrg()
            {
                Id = oi.IdentifierOrg?.Id,
                Name = oi.IdentifierOrg?.Name,
                RorId = oi.IdentifierOrg?.RorId
            }
        }).ToArray();
    }

    public ObjectInstanceListResponse[] MapObjectInstances(ObjectInstance[] objectInstances)
    {
        return objectInstances.Select(oi => new ObjectInstanceListResponse()
        {
            Id = oi.Id,
            RepositoryOrg = oi.RepositoryOrg?.Name,
            AccessDetails = new Contracts.Responses.v1.DTO.v1.Common.InstanceAccessDetails
            {
                DirectAccess = oi.AccessDetails?.DirectAccess,
                Url = oi.AccessDetails?.Url,
                UrlLastChecked = oi.AccessDetails?.UrlLastChecked
            },
            ResourceDetails = new Contracts.Responses.v1.DTO.v1.Common.InstanceResourceDetails()
            {
                TypeId = oi.ResourceDetails?.TypeId,
                TypeName = oi.ResourceDetails?.TypeName,
                Size = oi.ResourceDetails?.Size.ToString(),
                SizeUnit = oi.ResourceDetails?.SizeUnit,
                Comments = oi.ResourceDetails?.Comments
            }
        }).ToArray();
    }

    public ObjectRelationshipListResponse[] MapObjectRelationships(ObjectRelationship[] objectRelationships)
    {
        return objectRelationships.Select(or => new ObjectRelationshipListResponse()
        {
            Id = or.Id,
            RelationshipType = or.RelationshipType?.Name,
            TargetObjectId = or.TargetObjectId
        }).ToArray();
    }

    public ObjectRightListResponse[] MapObjectRights(ObjectRight[] objectRights)
    {
        return objectRights.Select(or => new ObjectRightListResponse()
        {
            Id = or.Id,
            RightsName = or.RightsName,
            RightsUrl = or.RightsUrl,
            Comments = or.Comments
        }).ToArray();
    }

    public ObjectTitleListResponse[] MapObjectTitles(ObjectTitle[] objectTitles)
    {
        return objectTitles.Select(ot => new ObjectTitleListResponse()
        {
            Id = ot.Id,
            TitleType = ot.TitleType?.Name,
            TitleText = ot.TitleText,
            LangCode = ot.LangCode,
            Comments = ot.Comments
        }).ToArray();
    }

    public ObjectTopicListResponse[] MapObjectTopics(ObjectTopic[] objectTopics)
    {
        return objectTopics.Select(ot => new ObjectTopicListResponse()
        {
            Id = ot.Id,
            TopicType = ot.TopicType?.Name,
            MeshCoded = ot.MeshCoded,
            MeshCode = ot.MeshCode,
            MeshValue = ot.MeshValue,
            OriginalCtId = ot.OriginalCtId,
            OriginalCtCode = ot.OriginalCtCode,
            OriginalValue = ot.OriginalValue
        }).ToArray();
    }

    private static string? ObjectUrlExtraction(ObjectInstance[]? objectInstances)
    {
        if (objectInstances is { Length: 0 }) return string.Empty;
        return !string.IsNullOrEmpty(objectInstances!.First().AccessDetails?.Url) ? objectInstances!.First().AccessDetails?.Url : string.Empty;
    }

    public ObjectListResponse BuildElasticsearchObjectResponse(DataObject dataObject)
    {
        return new ObjectListResponse()
        {
            Id = dataObject.Id,
            Doi = dataObject.Doi,
            DisplayTitle = dataObject.DisplayTitle,
            Version = dataObject.Version,
            ObjectClass = dataObject.ObjectClass?.Name,
            ObjectType = dataObject.ObjectType?.Name,
            ObjectUrl = ObjectUrlExtraction(dataObject.ObjectInstances),
            PublicationYear = dataObject.PublicationYear,
            LangCode = dataObject.LangCode,
            ManagingOrganisation = new Contracts.Responses.v1.DTO.v1.Common.ManagingOrg
            {
                Id = dataObject.ManagingOrganisation?.Id,
                Name = dataObject.ManagingOrganisation?.Name,
                RorId = dataObject.ManagingOrganisation?.RorId
            },
            AccessType = dataObject.AccessType?.Name,
            AccessDetails = new Contracts.Responses.v1.DTO.v1.Common.AccessDetails
            {
                Description = dataObject.AccessDetails?.Description,
                Url = dataObject.AccessDetails?.Url,
                UrlLastChecked = dataObject.AccessDetails?.UrlLastChecked
            },
            EoscCategory = dataObject.EoscCategory,
            DatasetRecordKeys = dataObject.DatasetRecordKeys != null ? MapDatasetRecordKeys(dataObject.DatasetRecordKeys) : null,
            DatasetDeidentLevel = dataObject.DatasetDeidentLevel != null ? MapDatasetDeidentLevel(dataObject.DatasetDeidentLevel) : null,
            DatasetConsent = dataObject.DatasetConsent != null ? MapDatasetConsent(dataObject.DatasetConsent) : null,
            ObjectContributors = dataObject.ObjectContributors!.Length > 0 ? MapObjectContributors(dataObject.ObjectContributors) 
                : Array.Empty<ObjectContributorListResponse>(),
            ObjectDates = dataObject.ObjectDates!.Length > 0 ? MapObjectDates(dataObject.ObjectDates) : Array.Empty<ObjectDateListResponse>(),
            ObjectDescriptions = dataObject.ObjectDescriptions!.Length > 0 ? MapObjectDescriptions(dataObject.ObjectDescriptions) 
                : Array.Empty<ObjectDescriptionListResponse>(),
            ObjectIdentifiers = dataObject.ObjectIdentifiers!.Length > 0 ? MapObjectIdentifiers(dataObject.ObjectIdentifiers) 
                : Array.Empty<ObjectIdentifierListResponse>(),
            ObjectInstances = dataObject.ObjectInstances!.Length > 0 ? MapObjectInstances(dataObject.ObjectInstances) 
                : Array.Empty<ObjectInstanceListResponse>(),
            ObjectRelationships = dataObject.ObjectRelationships!.Length > 0 ? MapObjectRelationships(dataObject.ObjectRelationships) 
                : Array.Empty<ObjectRelationshipListResponse>(),
            ObjectRights = dataObject.ObjectRights!.Length > 0 ? MapObjectRights(dataObject.ObjectRights) : Array.Empty<ObjectRightListResponse>(),
            ObjectTitles = dataObject.ObjectTitles!.Length > 0 ? MapObjectTitles(dataObject.ObjectTitles) : Array.Empty<ObjectTitleListResponse>(),
            ObjectTopics = dataObject.ObjectTopics!.Length > 0 ? MapObjectTopics(dataObject.ObjectTopics) : Array.Empty<ObjectTopicListResponse>(),
            LinkedStudies = dataObject.LinkedStudies,
            ProvenanceString = dataObject.ProvenanceString
        };
    }

    public ObjectListResponse[] BuildElasticsearchObjectListResponse(DataObject[]? dataObjects)
    {
        return dataObjects!.Select(BuildElasticsearchObjectResponse).ToArray();
    }

    public StudyListResponse BuildElasticsearchStudyResponse(Study study)
    {
        return new StudyListResponse()
        {
            Id = study.Id,
            DisplayTitle = study.DisplayTitle,
            BriefDescription = study.BriefDescription,
            StudyType = study.StudyType?.Name,
            StudyStatus = study.StudyStatus?.Name,
            StudyGenderElig = study.StudyGenderElig?.Name,
            StudyEnrolment = study.StudyEnrolment,
            MinAge = new AgeResponse
            {
                UnitName = study.MinAge?.UnitName,
                Value = study.MinAge?.Value
            },
            MaxAge = new AgeResponse
            {
                UnitName = study.MaxAge?.UnitName,
                Value = study.MaxAge?.Value
            },
            StudyIdentifiers = study.StudyIdentifiers!.Length > 0 ? MapStudyIdentifiers(study.StudyIdentifiers) : Array.Empty<StudyIdentifierListResponse>(),
            StudyFeatures = study.StudyFeatures!.Length > 0 ? MapStudyFeatures(study.StudyFeatures) : Array.Empty<StudyFeatureListResponse>(),
            StudyRelationships = study.StudyRelationships!.Length > 0 ? MapStudyRelationships(study.StudyRelationships) : Array.Empty<StudyRelationListResponse>(),
            StudyTitles = study.StudyTitles!.Length > 0 ? MapStudyTitles(study.StudyTitles) : Array.Empty<StudyTitleListResponse>(),
            StudyTopics = study.StudyTopics!.Length > 0 ? MapStudyTopics(study.StudyTopics) : Array.Empty<StudyTopicListResponse>(),
            ProvenanceString = study.ProvenanceString
        };
    }

    public StudyListResponse[] BuildElasticsearchStudyListResponse(Study[] studies)
    {
        return studies.Select(BuildElasticsearchStudyResponse).ToArray();
    }
}