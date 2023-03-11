using System.Text.Json.Serialization;

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
