using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Templates;

public class SafetyCultureTemplate
{
    [JsonPropertyName("template_id")] public required string TemplateId { get; set; }
    [JsonPropertyName("name")] public required string Name { get; set; }
    [JsonPropertyName("created_at")] public required DateTimeOffset CreatedAt { get; set; }
    [JsonPropertyName("modified_at")] public required DateTimeOffset ModifiedAt { get; set; }
}