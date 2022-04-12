using System.Text.Json.Serialization; 
namespace SafetyCulture.Model.Audits
{ 

    public class Selected
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

        [JsonPropertyName("enable_score")]
        public bool EnableScore { get; set; }

        [JsonPropertyName("failed")]
        public bool Failed { get; set; }
    }

}