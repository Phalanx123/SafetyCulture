using SafetyCulture.Model.Audits;
using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Webhooks
{
    public class Data
    {
        [JsonPropertyName("audit")]
        public InspectionHeader Audit { get; set; }

        [JsonPropertyName("template")]
        public Template Template { get; set; }
    }
}
