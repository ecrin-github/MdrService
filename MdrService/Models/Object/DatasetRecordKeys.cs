using Nest;

namespace MdrService.Models.Object;

public class DatasetRecordKeys
{
    [Number(Name = "keys_type_id")]
    public int? KeysTypeId { get; set; }
        
    [Text(Name = "keys_type")]
    public string? KeysType { get; set; }
        
    [Text(Name = "keys_details")]
    public string? KeysDetails { get; set; }
}