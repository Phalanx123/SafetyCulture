using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Webhooks
{
    public class Template
    {
        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }
    }
}
