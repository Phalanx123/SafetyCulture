using System.Text.Json.Serialization;

namespace SafetyCulture.Model.ResponseSets
{
    public class ResponseSetItem
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }
        [JsonPropertyName("label")]
        public string? Label { get; set; }
        [JsonPropertyName("short_label")]
        public string? ShortLabel { get; set; }
    }
}
