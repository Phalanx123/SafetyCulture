using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model
{
    public class ResponseError
    {
        public int Code { get; set; }
        public string Message { get; set; }
        public List<Detail> Details { get; set; }

    }
    public class Detail
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }
        // Additional properties based on your requirements
    }

}
