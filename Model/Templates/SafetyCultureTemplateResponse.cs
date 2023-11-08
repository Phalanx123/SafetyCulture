using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Templates;

public class SafetyCultureTemplateResponse
{
    [JsonPropertyName("total")]
    public required int Total { get; set; }
    [JsonPropertyName("count")]
    public required int Count { get; set; }
    [JsonPropertyName("templates")]
    public IEnumerable<SafetyCultureTemplate>? Templates { get; set; }
}