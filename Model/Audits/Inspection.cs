using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits
{
    public class Inspection
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        [JsonPropertyName("site_id")]
        public string SiteId { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime? ModifiedAt { get; set; }

        [JsonPropertyName("modified_by")]
        public ModifiedBy ModifiedBy { get; set; }

        [JsonPropertyName("permissions")]
        public Permissions Permissions { get; set; }

        [JsonPropertyName("is_marked_as_complete")]
        public bool? IsMarkedAsComplete { get; set; }

        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }

        [JsonPropertyName("media")]
        public List<InspectionMedium> Media { get; set; }

        [JsonPropertyName("revision_id")]
        public string RevisionId { get; set; }

        [JsonPropertyName("site")]
        public Site Site { get; set; }

        [JsonPropertyName("started_on")]
        public object StartedOn { get; set; }

        [JsonPropertyName("revision_key")]
        public string RevisionKey { get; set; }

        [JsonPropertyName("start_trigger")]
        public object StartTrigger { get; set; }
    }

    public class InspectionMedium
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }
    }

    public class ModifiedBy
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("value")]
        public string Value { get; set; }
    }

    public class Permissions
    {
        [JsonPropertyName("isOwner")]
        public bool? IsOwner { get; set; }

        [JsonPropertyName("canView")]
        public bool? CanView { get; set; }

        [JsonPropertyName("canEdit")]
        public bool? CanEdit { get; set; }

        [JsonPropertyName("canDelete")]
        public bool? CanDelete { get; set; }
    }

    public class InspectionResponse
    {
        [JsonPropertyName("inspection")]
        public Inspection Inspection { get; set; }
    }

    public class Site
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }

}
