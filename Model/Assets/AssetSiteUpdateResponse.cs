using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Assets
{
    public class AssetSiteUpdateResponse
    {
        [JsonPropertyName("success_count")]
        public int? SuccessCount { get; set; }

        [JsonPropertyName("failed_ids")]
        public List<Guid>? FailedIds { get; set; }
    }
}
