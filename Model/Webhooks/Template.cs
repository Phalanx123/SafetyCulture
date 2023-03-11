using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Webhooks
{
    public class Template
    {
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
