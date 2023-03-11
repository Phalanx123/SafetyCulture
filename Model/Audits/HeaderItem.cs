using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits
{
    public class HeaderItem
    {
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("scoring")]
        public Scoring Scoring { get; set; }

        [JsonPropertyName("children")]
        public List<string> Children { get; set; }

        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }

        [JsonPropertyName("options")]
        public Options Options { get; set; }

        [JsonPropertyName("responses")]
        public Responses Responses { get; set; }
    }
}
