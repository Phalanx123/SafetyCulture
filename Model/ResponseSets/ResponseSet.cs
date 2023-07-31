using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.ResponseSets
{
    public class ResponseSet
    {
        public string? Name { get; set; }
        [JsonPropertyName("responses")]
        public List<ResponseSetItem>? Responses { get; set; }
    }
}
