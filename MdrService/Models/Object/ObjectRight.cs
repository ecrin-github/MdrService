using Nest;

namespace MdrService.Models.Object;

public class ObjectRight
{
    [Number(Name = "id")]
    public int? Id { get; set; }
        
    [Text(Name = "rights_name")]
    public string? RightsName { get; set; }
        
    [Text(Name = "rights_url")]
    public string? RightsUrl { get; set; }
        
    [Text(Name = "comments")]
    public string? Comments { get; set; }
}