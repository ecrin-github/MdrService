using Nest;

namespace MdrService.Models.Study;

public class MaxAge
{
    [Number(Name = "value")]
    public int? Value { get; set; }
        
    [Number(Name = "unit_id")]
    public int? UnitId { get; set; }
        
    [Text(Name = "unit_name")]
    public string? UnitName { get; set; }
}