using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Audits
{
    public class AuditDataLegacy
    {
        [JsonPropertyName("site")]
        public SiteLegacy Site { get; set; }
        [JsonPropertyName("score")]
        public int? Score { get; set; }

        [JsonPropertyName("total_score")]
        public int? TotalScore { get; set; }

        [JsonPropertyName("score_percentage")]
        public double? ScorePercentage { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("authorship")]
        public AuthorshipLegacy Authorship { get; set; }

        [JsonPropertyName("date_completed")]
        public DateTime? DateCompleted { get; set; }

        [JsonPropertyName("date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonPropertyName("date_started")]
        public DateTime? DateStarted { get; set; }
    }

    public class AuthorshipLegacy
    {
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("author_id")]
        public string AuthorId { get; set; }
    }
    public class HeaderItemLegacy
    {
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("scoring")]
        public ScoringLegacy Scoring { get; set; }

        [JsonPropertyName("children")]
        public List<string> Children { get; set; }

        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }

        [JsonPropertyName("options")]
        public OptionsLegacy Options { get; set; }

        [JsonPropertyName("responses")]
        public ResponsesLegacy Responses { get; set; }
    }

    public class ImageLegacy
    {
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonPropertyName("file_ext")]
        public string FileExt { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("media_id")]
        public string MediaId { get; set; }

        [JsonPropertyName("href")]
        public string Href { get; set; }
    }

    public class ItemLegacy
    {
        [JsonPropertyName("item_id")]
        public string ItemId { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("scoring")]
        public ScoringLegacy Scoring { get; set; }

        [JsonPropertyName("children")]
        public List<string> Children { get; set; }

        [JsonPropertyName("parent_id")]
        public string ParentId { get; set; }

        [JsonPropertyName("options")]
        public OptionsLegacy Options { get; set; }

        [JsonPropertyName("responses")]
        public ResponsesLegacy Responses { get; set; }

        [JsonPropertyName("evaluation")]
        public bool? Evaluation { get; set; }

        [JsonPropertyName("inactive")]
        public bool? Inactive { get; set; }

        [JsonPropertyName("media")]
        public List<MediumLegacy> Media { get; set; }
    }

    public class MediumLegacy
    {
        [JsonPropertyName("date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonPropertyName("file_ext")]
        public string FileExt { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("media_id")]
        public string MediaId { get; set; }

        [JsonPropertyName("href")]
        public string Href { get; set; }
    }

    public class MetadataLegacy
    {
        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("image")]
        public ImageLegacy Image { get; set; }
    }

    public class OptionsLegacy
    {
        [JsonPropertyName("is_mandatory")]
        public bool? IsMandatory { get; set; }

        [JsonPropertyName("enable_date")]
        public bool? EnableDate { get; set; }

        [JsonPropertyName("enable_time")]
        public bool? EnableTime { get; set; }

        [JsonPropertyName("response_set")]
        public string ResponseSet { get; set; }

        [JsonPropertyName("failed_responses")]
        public List<object> FailedResponses { get; set; }

        [JsonPropertyName("values")]
        public List<string> Values { get; set; }

        [JsonPropertyName("condition")]
        public string Condition { get; set; }
    }

    public class ResponsesLegacy
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("colour")]
        public string Colour { get; set; }

        [JsonPropertyName("score")]
        public int? Score { get; set; }

        [JsonPropertyName("enable_score")]
        public bool? EnableScore { get; set; }

        [JsonPropertyName("failed")]
        public bool? Failed { get; set; }

        [JsonPropertyName("short_label")]
        public string ShortLabel { get; set; }

        [JsonPropertyName("datetime")]
        public DateTime? Datetime { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("selected")]
        public List<SelectedLegacy> Selected { get; set; }

        [JsonPropertyName("value")]
        public object? Value { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTime? Timestamp { get; set; }

        [JsonPropertyName("image")]
        public ImageLegacy Image { get; set; }
    }


    public class AuditLegacy
    {
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        [JsonPropertyName("audit_id")]
        public string AuditId { get; set; }

        [JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime? ModifiedAt { get; set; }

        [JsonPropertyName("audit_data")]
        public AuditDataLegacy? AuditData { get; set; }

        [JsonPropertyName("template_data")]
        public TemplateDataLegacy? TemplateData { get; set; }

        [JsonPropertyName("header_items")]
        public List<HeaderItemLegacy>? HeaderItems { get; set; }

        [JsonPropertyName("items")]
        public List<ItemLegacy>? Items { get; set; }
    }

    public class ScoringLegacy
    {
        [JsonPropertyName("combined_score")]
        public int? CombinedScore { get; set; }

        [JsonPropertyName("combined_max_score")]
        public int? CombinedMaxScore { get; set; }

        [JsonPropertyName("combined_score_percentage")]
        public double? CombinedScorePercentage { get; set; }

        [JsonPropertyName("score")]
        public double? Score { get; set; }

        [JsonPropertyName("max_score")]
        public double? MaxScore { get; set; }

        [JsonPropertyName("score_percentage")]
        public double? ScorePercentage { get; set; }
    }

    public class SelectedLegacy
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("colour")]
        public string Colour { get; set; }

        [JsonPropertyName("score")]
        public int? Score { get; set; }

        [JsonPropertyName("short_label")]
        public string ShortLabel { get; set; }

        [JsonPropertyName("failed")]
        public bool? Failed { get; set; }

        [JsonPropertyName("enable_score")]
        public bool? EnableScore { get; set; }
    }

    public class SiteLegacy
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

       
    }
    public class TemplateDataLegacy
    {
        [JsonPropertyName("authorship")]
        public AuthorshipLegacy Authorship { get; set; }

        [JsonPropertyName("metadata")]
        public MetadataLegacy Metadata { get; set; }

    }


}
