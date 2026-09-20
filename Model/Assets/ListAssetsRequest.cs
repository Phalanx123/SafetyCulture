using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Assets;

/// <summary>
/// The body of POST /assets/v1/assets/list. Every member is optional; SafetyCulture answers with the
/// first page of the organisation's assets when none is given.
/// </summary>
public sealed class ListAssetsRequest
{
    /// <summary>
    /// The key words to search for. SafetyCulture treats this as a keyword match, so it must be
    /// omitted rather than sent empty when nothing has been typed.
    /// </summary>
    [JsonPropertyName("search")]
    public string? Search { get; set; }

    /// <summary>
    /// How many assets to return. SafetyCulture accepts 1 to 100 and defaults to 50.
    /// </summary>
    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    /// <summary>The <see cref="ListAssetsResponse.NextPageToken"/> of the previous page.</summary>
    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    /// <summary>
    /// Filters combined with AND across different members and OR within the same member, so two
    /// filters naming a type return assets of either type.
    /// </summary>
    [JsonPropertyName("asset_filters")]
    public List<AssetFilter>? AssetFilters { get; set; }

    [JsonPropertyName("order_by")]
    public AssetsOrderBy? OrderBy { get; set; }
}

public sealed class AssetFilter
{
    [JsonPropertyName("type_id")]
    public Guid? TypeId { get; set; }

    [JsonPropertyName("site_id")]
    public string? SiteId { get; set; }

    /// <summary>One of the <see cref="AssetState"/> values.</summary>
    [JsonPropertyName("state")]
    public string? State { get; set; }

    [JsonPropertyName("asset_code")]
    public string? AssetCode { get; set; }
}

/// <summary>The states SafetyCulture recognises on <see cref="AssetFilter.State"/>.</summary>
public static class AssetState
{
    public const string Active = "ASSET_STATE_ACTIVE";
    public const string Archived = "ASSET_STATE_ARCHIVED";
}

public sealed class AssetsOrderBy
{
    /// <summary>One of the <see cref="AssetSortField"/> values.</summary>
    [JsonPropertyName("sort_field")]
    public string? SortField { get; set; }

    /// <summary>One of the <see cref="AssetSortDirection"/> values.</summary>
    [JsonPropertyName("sort_direction")]
    public string? SortDirection { get; set; }

    /// <summary>Required when sorting by <see cref="AssetSortField.AssetField"/>.</summary>
    [JsonPropertyName("field_id")]
    public string? FieldId { get; set; }
}

public static class AssetSortField
{
    public const string CreatedAt = "SORT_FIELD_CREATED_AT";
    public const string ModifiedAt = "SORT_FIELD_MODIFIED_AT";
    public const string Code = "SORT_FIELD_CODE";
    public const string AssetField = "SORT_FIELD_ASSET_FIELD";
    public const string InspectedAt = "SORT_FIELD_INSPECTED_AT";
    public const string StatusOptionName = "SORT_FIELD_STATUS_OPTION_NAME";
}

public static class AssetSortDirection
{
    public const string Ascending = "SORT_DIRECTION_ASC";
    public const string Descending = "SORT_DIRECTION_DESC";
}

public sealed class ListAssetsResponse
{
    [JsonPropertyName("assets")]
    public List<Asset>? Assets { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
