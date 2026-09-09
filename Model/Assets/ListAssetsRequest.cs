using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Assets;

public sealed class ListAssetsRequest
{
    [JsonPropertyName("search")]
    public string? Search { get; set; }

    [JsonPropertyName("page_size")]
    public int? PageSize { get; set; }

    [JsonPropertyName("page_token")]
    public string? PageToken { get; set; }

    [JsonPropertyName("asset_filters")]
    public List<AssetFilter>? AssetFilters { get; set; }
}

public sealed class AssetFilter
{
    [JsonPropertyName("type_id")]
    public Guid? TypeId { get; set; }
}

public sealed class ListAssetsResponse
{
    [JsonPropertyName("assets")]
    public List<Asset>? Assets { get; set; }

    [JsonPropertyName("next_page_token")]
    public string? NextPageToken { get; set; }
}
