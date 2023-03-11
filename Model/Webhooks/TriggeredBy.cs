using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Webhooks
{
    public class TriggeredBy
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("user")]
        public string User { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
