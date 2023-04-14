using SafetyCulture.Model.Folders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Assets
{
    public class Field
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("string_value")]
        public string? StringValue { get; set; }

        [JsonPropertyName("field_id")]
        public string? FieldId { get; set; }
    }

    public class ProfileImage
    {
        [JsonPropertyName("id")]
        public string? Id { get; set; }

        [JsonPropertyName("token")]
        public string? Token { get; set; }

        [JsonPropertyName("filename")]
        public string? Filename { get; set; }

        [JsonPropertyName("media_type")]
        public string? MediaType { get; set; }
    }

    public class Asset
    {
        [JsonPropertyName("id")]
        public Guid? Id { get; set; }

        [JsonPropertyName("code")]
        public string? Code { get; set; }

        [JsonPropertyName("type")]
        public Type? Type { get; set; }

        [JsonPropertyName("fields")]
        public List<Field>? Fields { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime? ModifiedAt { get; set; }

        [JsonPropertyName("site")]
        public Folder? Site { get; set; }

        [JsonPropertyName("profile_image")]
        public ProfileImage? ProfileImage { get; set; }

        [JsonPropertyName("state")]
        public string? State { get; set; }
        [JsonPropertyName("type_id")]
        public Guid? TypeId { get; set; }
    }

    

    public class Type
    {
        [JsonPropertyName("name")]
        public string? Name { get; set; }

        [JsonPropertyName("type_id")]
        public string? TypeId { get; set; }
    }

}
