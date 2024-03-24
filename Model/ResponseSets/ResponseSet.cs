using System.Text.Json.Serialization;

namespace SafetyCulture.Model.ResponseSets
{
    public class ResponseSet
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }
        [JsonPropertyName("responses")]
        public List<ResponseSetItem>? Responses { get; set; }
    }
}
