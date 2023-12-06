using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Audits
{
  public class InspectionAnswerResponse
    {
        [JsonPropertyName("result")]
        public Result Result { get; set; }
    }

    public class Result
    {
        [JsonPropertyName("question_id")]
        public string QuestionId { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime? ModifiedAt { get; set; }

        [JsonPropertyName("question_answer")]
        public AnswerDetails QuestionAnswer { get; set; }

        [JsonPropertyName("text_answer")]
        public TextAnswer TextAnswer { get; set; }

        [JsonPropertyName("media_answer")]
        public MediaAnswer MediaAnswer { get; set; }

        [JsonPropertyName("list_answer")]
        public ListAnswer ListAnswer { get; set; }

        [JsonPropertyName("signature_answer")]
        public SignatureAnswer SignatureAnswer { get; set; }

        [JsonPropertyName("datetime_answer")]
        public DateTimeAnswer DateTimeAnswer { get; set; }

        [JsonPropertyName("site_answer")]
        public SiteAnswer SiteAnswer { get; set; }

        [JsonPropertyName("location")]
        public Location Location { get; set; }
    }

    public class AnswerDetails
    {
        [JsonPropertyName("responses")]
        public List<string> Responses { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("media")]
        public List<Media> Media { get; set; }

        [JsonPropertyName("attachments")]
        public Attachment Attachments { get; set; }
    }

    public class TextAnswer
    {
        [JsonPropertyName("answer")]
        public string Answer { get; set; }

        [JsonPropertyName("attachments")]
        public Attachment Attachments { get; set; }
    }

    public class MediaAnswer
    {
        [JsonPropertyName("media")]
        public List<Media> Media { get; set; }

        [JsonPropertyName("attachments")]
        public Attachment Attachments { get; set; }
    }

    public class ListAnswer
    {
        [JsonPropertyName("responses")]
        public List<string> Responses { get; set; }

        [JsonPropertyName("note")]
        public string Note { get; set; }

        [JsonPropertyName("media")]
        public List<Media> Media { get; set; }

        [JsonPropertyName("attachments")]
        public Attachment Attachments { get; set; }
    }

    public class SignatureAnswer
    {
        [JsonPropertyName("media")]
        public Media Media { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("signed_at")]
        public DateTime? SignedAt { get; set; }

        [JsonPropertyName("attachments")]
        public Attachment Attachments { get; set; }
    }

    public class DateTimeAnswer
    {
        [JsonPropertyName("answer")]
        public DateTime? Answer { get; set; }

        [JsonPropertyName("attachments")]
        public Attachment Attachments { get; set; }
    }

    public class SiteAnswer
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; }

        [JsonPropertyName("area")]
        public string Area { get; set; }
    }

    public class Media
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; }

        [JsonPropertyName("filename")]
        public string Filename { get; set; }

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }
    }

    public class Attachment
    {
        // Define properties for attachments if they have a specific structure
    }

    public class Location
    {
        // Define properties for Location if needed
    }
}
