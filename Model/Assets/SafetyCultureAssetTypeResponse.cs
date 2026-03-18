using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Assets;

public class SafetyCultureAssetTypeResponse
{
    [JsonPropertyName("id")]
    public required string Id { get; set; }
}