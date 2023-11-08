using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits;

/// <summary>
/// Inspection Filter for Exporting
/// </summary>
public class InspectionExportFilter
{
    [JsonPropertyName("search_text")]
    public string? SearchText { get; set; }
    [JsonPropertyName("template_ids")]
    public IEnumerable<string>? TemplateIds { get; set; }
    [JsonPropertyName("template_folders")]
    public IEnumerable<string>? TemplateFolders { get; set; }
    [JsonPropertyName("groups")]
    public IEnumerable<string>? Groups { get; set; }
    [JsonPropertyName("sites")]
    public IEnumerable<string>? Sites { get; set; }
    [JsonPropertyName("from_date")]
    public DateTime? FromDate { get; set; }
    [JsonPropertyName("to_date")]
    public DateTime? ToDate { get; set; }
    [JsonPropertyName("from_date_completed")]
    public DateTime? FromDateCompleted { get; set; }
    [JsonPropertyName("to_date_completed")]
    public DateTime? ToDateCompleted { get; set; }
    [JsonPropertyName("asset_ids")]
    public IEnumerable<string>? AssetIds { get; set; }
    [JsonPropertyName("owned")]
    public bool? Owned { get; set; }
    [JsonPropertyName("shared")]
    public bool? Shared { get; set; }
}