using SafetyCulture.Model.Audits;
using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Webhooks
{
    public class TemplateData
    {
        [JsonPropertyName("authorship")]
        public AuthorshipLegacy Authorship { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }
    }
}
