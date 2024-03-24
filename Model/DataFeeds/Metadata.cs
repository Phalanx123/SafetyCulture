using System.Text.Json.Serialization;

namespace SafetyCulture.Model.DataFeeds
{
	public class Metadata
	{
		[JsonPropertyName("next_page")]
		public string? NextPage { get; set; }

		[JsonPropertyName("remaining_records")]
		public int? RemainingRecords { get; set; }
	}
}
