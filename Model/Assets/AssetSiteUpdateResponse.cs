using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Assets
{
    public class AssetSiteUpdateResponse
    {
        [JsonPropertyName("success_count")]
        public int? SuccessCount { get; set; }

        [JsonPropertyName("failed_ids")]
        public List<Guid>? FailedIds { get; set; }
    }
}
