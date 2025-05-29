using System.Text.Json.Serialization;

namespace SafetyCulture.Model.DataFeeds
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class InspectionDatum
    {
        [JsonPropertyName("id")]
        public required string Id { get; set; }

        [JsonPropertyName("name")]
        public required string? Name { get; set; }

        [JsonPropertyName("archived")]
        public bool? Archived { get; set; }

        [JsonPropertyName("organisation_id")]
        public string? OrganisationId { get; set; }

        [JsonPropertyName("owner_name")]
        public string? OwnerName { get; set; }

        [JsonPropertyName("owner_id")]
        public string? OwnerId { get; set; }

        [JsonPropertyName("author_name")]
        public string? AuthorName { get; set; }

        [JsonPropertyName("author_id")]
        public string? AuthorId { get; set; }

        [JsonPropertyName("score")]
        public int? Score { get; set; }

        [JsonPropertyName("max_score")]
        public int? MaxScore { get; set; }

        [JsonPropertyName("score_percentage")]
        public double? ScorePercentage { get; set; }

        [JsonPropertyName("duration")]
        public int? Duration { get; set; }

        [JsonPropertyName("site_id")]
        public string? SiteId { get; set; }

        [JsonPropertyName("template_id")]
        public required string TemplateId { get; set; }

        [JsonPropertyName("template_name")]
        public required string? TemplateName { get; set; }

        [JsonPropertyName("template_author")]
        public string? TemplateAuthor { get; set; }

        [JsonPropertyName("date_started")]
        public DateTimeOffset? DateStarted { get; set; }

        [JsonPropertyName("date_completed")]
        public DateTimeOffset? DateCompleted { get; set; }

        [JsonPropertyName("date_modified")]
        public DateTimeOffset? DateModified { get; set; }

        [JsonPropertyName("created_at")]
        public DateTimeOffset? CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTimeOffset? ModifiedAt { get; set; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("document_no")]
        public string? DocumentNo { get; set; }

        [JsonPropertyName("prepared_by")]
        public string? PreparedBy { get; set; }

        [JsonPropertyName("location")]
        public string? Location { get; set; }

        [JsonPropertyName("conducted_on")]
        public DateTimeOffset? ConductedOn { get; set; }

        [JsonPropertyName("personnel")]
        public object? Personnel { get; set; }

        [JsonPropertyName("client_site")]
        public string? ClientSite { get; set; }

        [JsonPropertyName("asset_id")]
        public Guid? AssetId { get; set; }

        [JsonPropertyName("web_report_link")]
        public string? WebReportLink { get; set; }
    }

    public class InspectionDataFeed
    {
        [JsonPropertyName("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonPropertyName("data")]
        public List<InspectionDatum>? Data { get; set; }
    }


}
