using System.Text.Json.Serialization;
using SafetyCulture.Converters;

namespace SafetyCulture.Model.Templates;

public class SafetyCultureTemplateFilter
{
    [JsonPropertyName("limit")] public int Limit { get; set; } = 1000;
    [JsonPropertyName("modified_after")] public DateTime? ModifiedAfter { get; set; }
    [JsonPropertyName("modified_before")] public DateTime? ModifiedBefore { get; set; }
    [JsonConverter(typeof(Converter.EnumToStringConverter<OwnerTypeFilter>))]
    [JsonPropertyName("owner")] public OwnerTypeFilter? Owner { get; set; }
    
    [JsonConverter(typeof(Converter.EnumToStringConverterLower<OrderTypeFilter>))]
    [JsonPropertyName("order")] public OrderTypeFilter? Order { get; set; }
    
    [JsonConverter(typeof(Converter.EnumToStringConverterLower<ArchivedFilter>))]
    [JsonPropertyName("archived")]
    public ArchivedFilter Archived { get; set; } = ArchivedFilter.BOTH;
}

public enum ArchivedFilter
{
    FALSE,
    TRUE,
    BOTH
}
public enum OwnerTypeFilter
{
    ALL,
    ME,
    OTHER
}

public enum OrderTypeFilter
{
    ASC,
    DESC
}