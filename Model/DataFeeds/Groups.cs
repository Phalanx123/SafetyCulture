using System.Text.Json.Serialization;

namespace SafetyCulture.Model.DataFeeds
{
    public class GroupDatum
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("organisation_id")]
        public string? OrganisationId { get; set; }
    }

    public class GroupDataFeed
    {
        [JsonPropertyName("metadata")]
        public Metadata? Metadata { get; set; }

        [JsonPropertyName("data")]
        public List<GroupDatum>? Data { get; set; }
    }
}
