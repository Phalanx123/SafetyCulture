using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits
{
    public class InspectionHeader
    {
        [JsonPropertyName("audit_id")]
        public string AuditId { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime? ModifiedAt { get; set; }

        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }
    }

    public class InspectionHeaderResponse
    {
        [JsonPropertyName("count")]
        public int? Count { get; set; }

        [JsonPropertyName("total")]
        public int? Total { get; set; }

        [JsonPropertyName("audits")]
        public List<InspectionHeader> InspectionHeaders { get; set; }
    }


}