using System.Text.Json.Serialization;

namespace SafetyCulture.Model.InspectionDetails;

/// <summary>
/// Mirrors the payload returned by GET /inspections/v1/inspections/{id}/details — the full
/// item-tree detail for a single inspection, as opposed to the summary shape in
/// SafetyCulture.Model.Audits.Inspection.
/// </summary>
public sealed class InspectionDetailsResponse
{
    [JsonPropertyName("inspection")]
    public InspectionDetailsInspection? Inspection { get; init; }
}

public sealed class InspectionDetailsInspection
{
    [JsonPropertyName("metadata")]
    public InspectionDetailsMetadata? Metadata { get; init; }

    [JsonPropertyName("template")]
    public InspectionDetailsTemplate? Template { get; init; }

    [JsonPropertyName("items")]
    public List<InspectionDetailsItem> Items { get; init; } = [];
}

public sealed class InspectionDetailsMetadata
{
    [JsonPropertyName("inspection_id")]
    public string? InspectionId { get; init; }

    [JsonPropertyName("inspection_name")]
    public string? InspectionName { get; init; }

    [JsonPropertyName("completed_time")]
    public DateTimeOffset? CompletedTime { get; init; }

    [JsonPropertyName("created_time")]
    public DateTimeOffset? CreatedTime { get; init; }

    [JsonPropertyName("site")]
    public InspectionDetailsSite? Site { get; init; }

    [JsonPropertyName("owner")]
    public InspectionDetailsPersonRef? Owner { get; init; }

    [JsonPropertyName("last_modified_by")]
    public InspectionDetailsPersonRef? LastModifiedBy { get; init; }
}

public sealed class InspectionDetailsSite
{
    [JsonPropertyName("site_id")]
    public string? SiteId { get; init; }

    [JsonPropertyName("site_name")]
    public string? SiteName { get; init; }
}

public sealed class InspectionDetailsPersonRef
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }
}

public sealed class InspectionDetailsTemplate
{
    [JsonPropertyName("template_id")]
    public string? TemplateId { get; init; }

    [JsonPropertyName("template_name")]
    public string? TemplateName { get; init; }
}
