using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Assets
{
    public sealed class UpdateAssetTypeRequest
    {
        /// <summary>
        /// Type which replaces the one with matching identifier on the server.
        /// </summary>
        [JsonPropertyName("type")]
        public SafetyCultureAssetType? Type { get; set; }

        /// <summary>
        /// Required field mask indicating which attributes should be updated.
        /// For this endpoint, "name" is the documented field shown in the request body.
        /// </summary>
        [JsonPropertyName("update_mask")]
        public string UpdateMask { get; set; } = string.Empty;
    }
}