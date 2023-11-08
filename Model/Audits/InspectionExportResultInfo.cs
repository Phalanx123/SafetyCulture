using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits;

public class InspectionExportResultInfo
{
    [JsonPropertyName("subject")] public string? Subject { get; set; }
    [JsonPropertyName("details")] public string? Details { get; set; }
}