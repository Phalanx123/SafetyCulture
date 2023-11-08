using System.Globalization;
using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits;

/// <summary>
/// Inspection Export
/// </summary>
public class InspectionExport
{
    /// <summary>
    /// Document Format
    /// </summary>
    [JsonPropertyName("type")]
    public required ExportType ExportType { get; set; }

    /// <summary>
    /// Timezone
    /// </summary>
    [JsonPropertyName("timezone")]
    public string? Timezone { get; set; }

    /// <summary>
    /// Indicate whether to by pass any caching and regenerate the report from the latest data. This flag would only take effect for authorized user.
    /// </summary>
    [JsonPropertyName("regenerate")]
    public bool Regenerate { get; set; }
    
    /// <summary>
    /// Language i.e. en-US
    /// </summary>
    [JsonPropertyName("lang")]
    public CultureTypes Language { get; set; }

    /// <summary>
    /// Inspection Filter
    /// </summary>
    public InspectionExportFilter? InspectionFilter { get; set; }
    
    /// <summary>
    /// Additional Settings
    /// </summary>
    [JsonPropertyName("export_data")]
    public IEnumerable<InspectionExportData>? InspectionExportData { get; set; }
}

public enum ExportType
{
    DOCUMENT_TYPE_UNSPECIFIED,
    DOCUMENT_TYPE_PDF,
    DOCUMENT_TYPE_WORD,
    DOCUMENT_TYPE_MEDIA,
    DOCUMENT_TYPE_JSON,
    DOCUMENT_TYPE_CSV,
    DOCUMENT_TYPE_EXCEL,
    DOCUMENT_TYPE_CSV_MEDIA,
    DOCUMENT_TYPE_CSV_EXCEL,
}