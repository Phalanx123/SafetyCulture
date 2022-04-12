using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Webhooks
{
    public class Event
    {
        [JsonPropertyName("date_triggered")]
        public DateTime DateTriggered { get; set; }

        [JsonPropertyName("event_types")]
        public List<string> EventTypes { get; set; }

        [JsonPropertyName("triggered_by")]
        public TriggeredBy TriggeredBy { get; set; }
    }
}
