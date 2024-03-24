using System.Text.Json.Serialization;

namespace SafetyCulture.Model.ResponseSets
{
    public class ResponseSetResponse
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("ok")]
        public bool Success { get; set; }

    }
}
