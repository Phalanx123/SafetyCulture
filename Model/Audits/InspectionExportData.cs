using System.Text.Json.Serialization;
using SafetyCulture.Converters;

namespace SafetyCulture.Model.Audits;

public class InspectionExportData
{
    /// <summary>
    /// Inspection ID
    /// </summary>
    [JsonPropertyName("inspection_id")]
    public required string InspectionId { get; set; }

    [JsonPropertyName("preference_id")] public string? PreferenceId { get; set; }

    [JsonPropertyName("logo")] public required InspectionExportDataPreferenceOverrideCommonObject Logo { get; set; }

    [JsonPropertyName("cover_page")]
    public required InspectionExportDataPreferenceOverrideCommonObject CoverPage { get; set; }
}

public class InspectionExportDataPreferenceOverride
{
}

public class InspectionExportDataPreferenceOverrideCommonObject
{
    [JsonPropertyName("id")] public required Guid Id { get; set; }

    [JsonPropertyName("token")] public string? Token { get; set; }
    [JsonPropertyName("filename")] public string? Filename { get; set; }

    [JsonConverter(
        typeof(Converter.EnumToStringConverter<InspectionExportDataPreferenceOverrideCommonObjectMediaType>))]
    [JsonPropertyName("media_type")]
    public InspectionExportDataPreferenceOverrideCommonObjectMediaType? MediaType { get; set; }
}

public enum InspectionExportDataPreferenceOverrideCommonObjectMediaType
{
    MEDIA_TYPE_NONE_UNSPECIFIED,
    MEDIA_TYPE_IMAGE,
    MEDIA_TYPE_VIDEO,
    MEDIA_TYPE_PDF,
}