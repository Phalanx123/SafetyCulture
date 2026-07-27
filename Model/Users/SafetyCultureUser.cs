using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Users
{
    public class SafetyCultureUser
    {
        [JsonPropertyName("user_id")]
        public string? UserId { get; set; }

        [JsonPropertyName("org_id")]
        public string? OrgId { get; set; }

        [JsonPropertyName("status")]
        public string? Status { get; set; }

        [JsonPropertyName("first_name")]
        public string? FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string? LastName { get; set; }

        [JsonPropertyName("email")]
        public string? Email { get; set; }

        [JsonPropertyName("seat_type")]
        public string? SeatType { get; set; }

        [JsonPropertyName("timezone")]
        public string? Timezone { get; set; }

        [JsonPropertyName("mobile_phone")]
        public string? MobilePhone { get; set; }

        [JsonPropertyName("locale")]
        public string? Locale { get; set; }

        [JsonPropertyName("username")]
        public string? Username { get; set; }
    }

    public class ListUsersRequest
    {
        [JsonPropertyName("list_all")]
        public bool? ListAll { get; set; }

        [JsonPropertyName("page_token")]
        public string? PageToken { get; set; }
    }

    public class ListUsersResponse
    {
        [JsonPropertyName("users")]
        public List<SafetyCultureUser>? Users { get; set; }

        [JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }
    }
}
