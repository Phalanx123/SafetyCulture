using SafetyCulture.Model.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Webhooks
{
    public class TemplateData
    {
        [JsonPropertyName("authorship")]
        public Authorship Authorship { get; set; }

        [JsonPropertyName("metadata")]
        public Metadata Metadata { get; set; }
    }
}
