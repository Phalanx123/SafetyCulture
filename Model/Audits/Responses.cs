using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits
{
    public class Responses
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("colour")]
        public string Colour { get; set; }

        [JsonPropertyName("score")]
        public int Score { get; set; }

        [JsonPropertyName("short_label")]
        public string ShortLabel { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("failed")]
        public bool Failed { get; set; }

        [JsonPropertyName("enable_score")]
        public bool EnableScore { get; set; }

        [JsonPropertyName("datetime")]
        public DateTime Datetime { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("selected")]
        public List<Selected> Selected { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonPropertyName("image")]
        public Image Image { get; set; }
    }

}
