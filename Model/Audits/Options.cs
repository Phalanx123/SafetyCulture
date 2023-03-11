using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits
{
    public class Options
    {
        [JsonPropertyName("is_mandatory")]
        public bool IsMandatory { get; set; }

        [JsonPropertyName("enable_date")]
        public bool EnableDate { get; set; }

        [JsonPropertyName("enable_time")]
        public bool EnableTime { get; set; }

        [JsonPropertyName("weighting")]
        public int? Weighting { get; set; }

        [JsonPropertyName("response_set")]
        public string ResponseSet { get; set; }

        [JsonPropertyName("failed_responses")]
        public List<object> FailedResponses { get; set; }

        [JsonPropertyName("multiple_selection")]
        public bool? MultipleSelection { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("visible_in_audit")]
        public bool VisibleInAudit { get; set; }

        [JsonPropertyName("visible_in_report")]
        public bool VisibleInReport { get; set; }

        [JsonPropertyName("values")]
        public List<string> Values { get; set; }

        [JsonPropertyName("condition")]
        public string Condition { get; set; }

        [JsonPropertyName("enable_signature_timestamp")]
        public bool? EnableSignatureTimestamp { get; set; }
    }
}
