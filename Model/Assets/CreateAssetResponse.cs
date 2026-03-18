using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Assets;

public sealed class CreateAssetResponse
{
    [JsonPropertyName("id")]
    public string? Id { get; set; }
}