﻿using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Audits
{
    public class Authorship
    {
        [JsonPropertyName("device_id")]
        public string DeviceId { get; set; }

        [JsonPropertyName("owner")]
        public string Owner { get; set; }

        [JsonPropertyName("owner_id")]
        public string OwnerId { get; set; }

        [JsonPropertyName("author")]
        public string Author { get; set; }

        [JsonPropertyName("author_id")]
        public string AuthorId { get; set; }
    }
}
