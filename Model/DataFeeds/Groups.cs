using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
