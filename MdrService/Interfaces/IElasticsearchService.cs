using MdrService.Contracts.Requests.Elasticsearch.v1;
using MdrService.Contracts.Responses.v1;
using MdrService.Contracts.Responses.v1.DTO.v1.StudyListResponse;

namespace MdrService.Interfaces;

public interface IElasticsearchService
{
    Task<BaseResponse<StudyListResponse>> GetSpecificStudy(SpecificStudyEsRequest specificStudyRequest);
    Task<BaseResponse<StudyListResponse>> GetByStudyCharacteristics(StudyCharacteristicsEsRequest studyCharacteristicsRequest);
    Task<BaseResponse<StudyListResponse>> GetViaPublishedPaper(ViaPublishedPaperEsRequest viaPublishedPaperRequest);
    Task<BaseResponse<StudyListResponse>> GetByStudyId(StudyIdEsRequest studyIdRequest);
}