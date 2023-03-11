using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Webhooks
{
    public class AuditWebhook
    {
        [JsonPropertyName("version")]
        public string Version { get; set; }

        [JsonPropertyName("workflow_id")]
        public string WorkflowId { get; set; }

        [JsonPropertyName("event")]
        public Event Event { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }
}
