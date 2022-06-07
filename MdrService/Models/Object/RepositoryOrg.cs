using Nest;

namespace MdrService.Models.Object;

public class RepositoryOrg
{
    [Number(Name = "id")]
    public int? Id { get; set; }
        
    [Text(Name = "name")]
    public string? Name { get; set; }
}