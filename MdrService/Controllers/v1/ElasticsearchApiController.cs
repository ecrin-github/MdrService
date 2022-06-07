using MdrService.Configs;
using MdrService.Contracts.Requests.Elasticsearch.v1;
using MdrService.Contracts.Responses.v1;
using MdrService.Contracts.Responses.v1.DTO.v1.StudyListResponse;
using MdrService.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;

namespace MdrService.Controllers.v1;

[Route($"{ApiConfigs.ApiUrl}/{ApiConfigs.ApiVersion}")]
public class ElasticsearchApiController : BaseMdrApiController
{
    private readonly IElasticsearchService _elasticsearchService;
    
    public ElasticsearchApiController(IElasticsearchService elasticsearchService)
    {
        _elasticsearchService = elasticsearchService ?? throw new ArgumentNullException(nameof(elasticsearchService));
    }

    [HttpPost($"{ApiConfigs.SpecificStudyUrl}")]
    [SwaggerOperation(Tags = new[] { "ES - Search specific study" })]
    public async Task<IActionResult> GetSpecificStudy(SpecificStudyEsRequest specificStudyRequest)
    {
        var data = await _elasticsearchService.GetSpecificStudy(specificStudyRequest);
        return Ok(new ApiResponse<StudyListResponse>()
        {
            Total = data.Total,
            StatusCode = Ok().StatusCode,
            Message = string.Empty,
            Page = specificStudyRequest.Page,
            Size = specificStudyRequest.Size,
            Data = data.Data
        });
    }

    
    [HttpPost($"{ApiConfigs.StudyCharacteristicsUrl}")]
    [SwaggerOperation(Tags = new[] { "ES - Search by study characteristics" })]
    public async Task<IActionResult> GetByStudyCharacteristics(StudyCharacteristicsEsRequest studyCharacteristicsRequest)
    {
        var data = await _elasticsearchService.GetByStudyCharacteristics(studyCharacteristicsRequest);
        return Ok(new ApiResponse<StudyListResponse>()
        {
            Total = data.Total,
            StatusCode = Ok().StatusCode,
            Message = string.Empty,
            Page = studyCharacteristicsRequest.Page,
            Size = studyCharacteristicsRequest.Size,
            Data = data.Data
        });
    }
    
    
    [HttpPost($"{ApiConfigs.ViaPublishedPaperUrl}")]
    [SwaggerOperation(Tags = new[] { "ES - Search via published paper" })]
    public async Task<IActionResult> GetViaPublishedPaper(ViaPublishedPaperEsRequest viaPublishedPaperRequest)
    {
        var data = await _elasticsearchService.GetViaPublishedPaper(viaPublishedPaperRequest);
        return Ok(new ApiResponse<StudyListResponse>()
        {
            Total = data.Total,
            StatusCode = Ok().StatusCode,
            Message = string.Empty,
            Page = viaPublishedPaperRequest.Page,
            Size = viaPublishedPaperRequest.Size,
            Data = data.Data
        });
    }
    
    
    [HttpPost($"{ApiConfigs.ByStudyIdUrl}")]
    [SwaggerOperation(Tags = new[] { "ES - Search by study ID" })]
    public async Task<IActionResult> GetByStudyId(StudyIdEsRequest studyIdRequest)
    {
        var data = await _elasticsearchService.GetByStudyId(studyIdRequest);
        return Ok(new ApiResponse<StudyListResponse>()
        {
            Total = data.Total,
            StatusCode = Ok().StatusCode,
            Message = string.Empty,
            Data = data.Data
        });
    }
}