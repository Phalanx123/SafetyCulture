using System.Text.Json.Serialization;

namespace SafetyCulture.Model
{
    public class ResponseError
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<Detail> Details { get; set; }

    }
    public class Detail
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
        // Additional properties based on your requirements
    }

}
