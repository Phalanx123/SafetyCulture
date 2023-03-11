using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Webhooks
{
    public class Metadata
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

}
