using System.Text.Json.Serialization;
using SafetyCulture.Converters;

namespace SafetyCulture.Model.Audits;

public class InspectionExportResult
{
    [JsonPropertyName("url")] public string? Url { get; set; }

    [JsonConverter(typeof(Converter.EnumToStringConverter<InspectionExportStatus>))]
    [JsonPropertyName("status")]
    public InspectionExportStatus? Status { get; set; }

    [JsonConverter(typeof(Converter.EnumToStringConverter<InspectionExportVersion>))]
    [JsonPropertyName("version")]
    public InspectionExportVersion? InspectionExportVersion { get; set; }

    [JsonPropertyName("info")] public InspectionExportResultInfo[]? InspectionExportResultInfo { get; set; }
}

public enum InspectionExportStatus
{
    STATUS_UNSPECIFIED,
    STATUS_IN_PROGRESS,
    STATUS_FAILED,
    STATUS_DONE
}

public enum InspectionExportVersion
{
    VERSION_UNSPECIFIED,
    VERSION_1,
    VERSION_2,
    VERSION_3
}