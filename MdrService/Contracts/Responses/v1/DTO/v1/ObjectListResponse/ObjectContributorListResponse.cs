using MdrService.Contracts.Responses.v1.DTO.v1.Common;

namespace MdrService.Contracts.Responses.v1.DTO.v1.ObjectListResponse;

public class ObjectContributorListResponse
{
    public int? Id { get; set; }
        
    public string? ContributionType { get; set; }
        
    public bool? IsIndividual { get; set; }
        
    public ContribOrg? Organisation { get; set; }
        
    public Person? Person { get; set; }
}