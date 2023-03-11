using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits
{
    public class Audit
    {
        [JsonPropertyName("template_id")]
        public string TemplateID { get; set; }

        [JsonPropertyName("audit_id")]
        public string AuditID { get; set; }

        [JsonPropertyName("archived")]
        public bool Archived { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime ModifiedAt { get; set; }

        [JsonPropertyName("audit_data")]
        public AuditData AuditData { get; set; }

        [JsonPropertyName("header_items")]
        public List<HeaderItem> HeaderItems { get; set; }

        [JsonPropertyName("items")]
        public List<Item> Items { get; set; }
    }
}