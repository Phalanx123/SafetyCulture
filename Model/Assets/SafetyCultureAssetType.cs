using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Assets
{
    public sealed class SafetyCultureAssetType
    {
        /// <summary>
        /// Name of the asset type.
        /// </summary>
        [JsonPropertyName("name")]
        public string? Name { get; set; }
    }
}