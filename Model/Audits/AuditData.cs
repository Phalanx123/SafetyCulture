using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits
{
    public class AuditData
    {
        [JsonPropertyName("score")]
        public int Score { get; set; }
        [JsonPropertyName("total_score")]
        public int TotalScore { get; set; }
        [JsonPropertyName("score_percentage")]
        public double ScorePercentage { get; set; }
        [JsonPropertyName("name")]
        public string Name { get; set; }
        [JsonPropertyName("duration")]
        public int Duration { get; set; }
        [JsonPropertyName("date_completed")]
        public DateTime DateCompleted { get; set; }
        [JsonPropertyName("date_modified")]
        public DateTime DateModified { get; set; }
        [JsonPropertyName("date_started")]
        public DateTime DateStarted { get; set; }

        [JsonPropertyName("authorship")]
        public Authorship Authorship { get; set; }
    }
}
