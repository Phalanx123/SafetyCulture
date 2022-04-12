using System.Text.Json.Serialization; 
namespace SafetyCulture.Model.Audits
{ 

    public class Scoring
    {
        [JsonPropertyName("combined_score")]
        public int CombinedScore { get; set; }

        [JsonPropertyName("combined_max_score")]
        public int CombinedMaxScore { get; set; }

        [JsonPropertyName("combined_score_percentage")]
        public int CombinedScorePercentage { get; set; }

        [JsonPropertyName("score")]
        public int? Score { get; set; }

        [JsonPropertyName("max_score")]
        public int? MaxScore { get; set; }

        [JsonPropertyName("score_percentage")]
        public int? ScorePercentage { get; set; }
    }

}