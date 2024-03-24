using System.Text.Json.Serialization;

namespace SafetyCulture.Model.DataFeeds
{
    public class TemplatePermissionsDatum
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        [JsonPropertyName("permission")]
        public string Permission { get; set; }

        [JsonPropertyName("assignee_type")]
        public string AssigneeType { get; set; }

        [JsonPropertyName("assignee_id")]
        public string AssigneeId { get; set; }

        [JsonPropertyName("organisation_id")]
        public string OrganisationId { get; set; }
    }


    public class TemplatePermissionsDataFeed
    {
        [JsonPropertyName("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonPropertyName("data")]
        public List<TemplatePermissionsDatum>? Data { get; set; }
    }

}
