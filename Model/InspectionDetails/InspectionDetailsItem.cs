using System.Text.Json.Serialization;

namespace SafetyCulture.Model.InspectionDetails;

/// <summary>
/// A single node in the flat, parent-referencing item tree returned by the inspection details
/// endpoint. Only one of the "*_item" properties is populated, depending on <see cref="Type"/>
/// (e.g. "text", "textsingle", "question", "datetime", "address", "site", "user", "asset",
/// "repeated_section", "repeated_section_instance", "page", "section", "logic").
/// </summary>
public sealed class InspectionDetailsItem
{
    [JsonPropertyName("item_id")]
    public string ItemId { get; init; } = "";

    [JsonPropertyName("type")]
    public string Type { get; init; } = "";

    [JsonPropertyName("label")]
    public string? Label { get; init; }

    [JsonPropertyName("parent_id")]
    public string ParentId { get; init; } = "";

    [JsonPropertyName("text_item")]
    public InspectionDetailsTextItem? TextItem { get; init; }

    [JsonPropertyName("datetime_item")]
    public InspectionDetailsDateTimeItem? DateTimeItem { get; init; }

    [JsonPropertyName("address_item")]
    public InspectionDetailsAddressItem? AddressItem { get; init; }

    [JsonPropertyName("question_item")]
    public InspectionDetailsChoiceItem? QuestionItem { get; init; }

    [JsonPropertyName("list_items")]
    public InspectionDetailsChoiceItem? ListItems { get; init; }

    [JsonPropertyName("site_item")]
    public InspectionDetailsPersonRef? SiteItem { get; init; }

    [JsonPropertyName("user_item")]
    public InspectionDetailsPersonRef? UserItem { get; init; }

    [JsonPropertyName("asset_item")]
    public InspectionDetailsAssetItem? AssetItem { get; init; }
}

public sealed class InspectionDetailsTextItem
{
    [JsonPropertyName("text")]
    public string? Text { get; init; }
}

public sealed class InspectionDetailsDateTimeItem
{
    [JsonPropertyName("datetime")]
    public DateTimeOffset? DateTime { get; init; }
}

public sealed class InspectionDetailsAddressItem
{
    [JsonPropertyName("location_text")]
    public string? LocationText { get; init; }
}

public sealed class InspectionDetailsChoiceItem
{
    [JsonPropertyName("responses")]
    public List<InspectionDetailsChoiceResponse> Responses { get; init; } = [];
}

public sealed class InspectionDetailsChoiceResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("value")]
    public string? Value { get; init; }
}

public sealed class InspectionDetailsAssetItem
{
    [JsonPropertyName("id")]
    public string? Id { get; init; }

    [JsonPropertyName("name")]
    public string? Name { get; init; }
}
