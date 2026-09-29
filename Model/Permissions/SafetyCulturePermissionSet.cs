using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Permissions
{
    public class SafetyCulturePermissionSet
    {
        public required string Id { get; init; }
        public string? Name { get; init; }
        public string? Description { get; init; }
    }

    public class AssignPermissionSetRequest
    {
        [JsonPropertyName("user_ids")]
        public List<string> UserIds { get; set; } = [];

        [JsonPropertyName("id")]
        public string? Id { get; set; }
    }

    public class ListPermissionSetsRequest
    {
        [JsonPropertyName("limit")]
        public int Limit { get; set; }

        [JsonPropertyName("offset")]
        public int Offset { get; set; }
    }
}
