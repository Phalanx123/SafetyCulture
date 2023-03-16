using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Audits
{
    public class InspectionAnswerResult
    {
        [JsonPropertyName("question_id")]
        public string QuestionId { get; set; }

        [JsonPropertyName("modified_at")]
        public object ModifiedAt { get; set; }

        [JsonPropertyName("text_answer")]
        public TextAnswer TextAnswer { get; set; }

        [JsonPropertyName("location")]
        public object Location { get; set; }
    }

    public class InspectionAnswersResponse
    {
        [JsonPropertyName("result")]
        public List<InspectionAnswerResult> Results { get; set; }
    }

    public class TextAnswer
    {
        [JsonPropertyName("answer")]
        public string Answer { get; set; }

        [JsonPropertyName("attachments")]
        public object Attachments { get; set; }
    }

}
