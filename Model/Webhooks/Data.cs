using SafetyCulture.Model.Audits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Webhooks
{
    public class Data
    {
        [JsonPropertyName("audit")]
        public Audit Audit { get; set; }

        [JsonPropertyName("template")]
        public Template Template { get; set; }
    }
}
