using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Assets;

/// <summary>
/// Body of <c>PUT /assets/v1/assets/bulk</c>. Only the attributes named in <see cref="UpdateMask"/>
/// are applied; anything else in the body is ignored.
/// </summary>
public class BulkUpdateAssetsRequest
{
    public const string SiteMask = "site";

    [JsonPropertyName("assets")]
    public List<BulkUpdateAsset> Assets { get; set; } = [];

    [JsonPropertyName("update_mask")]
    public string UpdateMask { get; set; } = string.Empty;
}

public class BulkUpdateAsset
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }

    [JsonPropertyName("site")]
    [JsonIgnore(Condition = JsonIgnoreCondition.WhenWritingNull)]
    public BulkUpdateAssetSite? Site { get; set; }
}

public class BulkUpdateAssetSite
{
    [JsonPropertyName("id")]
    public Guid Id { get; set; }
}

public class BulkUpdateAssetsResponse
{
    [JsonPropertyName("updated_assets")]
    public List<BulkUpdatedAsset>? UpdatedAssets { get; set; }

    [JsonPropertyName("failed_assets")]
    public List<BulkFailedAsset>? FailedAssets { get; set; }
}

public class BulkUpdatedAsset
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}

public class BulkFailedAsset
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }

    [JsonPropertyName("status")]
    public BulkFailedAssetStatus? Status { get; set; }
}

public class BulkFailedAssetStatus
{
    [JsonPropertyName("code")]
    public int? Code { get; set; }

    [JsonPropertyName("message")]
    public string? Message { get; set; }
}
