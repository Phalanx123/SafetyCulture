using System.Text.Json.Serialization;

namespace SafetyCulture.Model.DataFeeds
{
	public class TemplateDatum
	{
		[JsonPropertyName("id")]
		public string? Id { get; set; }

		[JsonPropertyName("archived")]
		public bool? Archived { get; set; }

		[JsonPropertyName("name")]
		public string? Name { get; set; }

		[JsonPropertyName("description")]
		public string? Description { get; set; }

		[JsonPropertyName("owner_name")]
		public string? OwnerName { get; set; }

		[JsonPropertyName("owner_id")]
		public string? OwnerId { get; set; }

		[JsonPropertyName("author_name")]
		public string? AuthorName { get; set; }

		[JsonPropertyName("author_id")]
		public string? AuthorId { get; set; }

		[JsonPropertyName("organisation_id")]
		public string? OrganisationId { get; set; }

		[JsonPropertyName("created_at")]
		public DateTime? CreatedAt { get; set; }

		[JsonPropertyName("modified_at")]
		public DateTime? ModifiedAt { get; set; }
	}

	public class TemplateDataFeed
	{
		[JsonPropertyName("metadata")]
		public Metadata? Metadata { get; set; }

		[JsonPropertyName("data")]
		public List<TemplateDatum>? Data { get; set; }
	}
}
