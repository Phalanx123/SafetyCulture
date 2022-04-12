using System.Text.Json.Serialization; 
using System; 
namespace SafetyCulture.Model.Audits
{ 

    public class Image
    {
        [JsonPropertyName("date_created")]
        public DateTime DateCreated { get; set; }

        [JsonPropertyName("file_ext")]
        public string FileExt { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("media_id")]
        public string MediaId { get; set; }

        [JsonPropertyName("href")]
        public string Href { get; set; }
    }

}