using System.Text.Json.Serialization;
using SafetyCulture.Converters;

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

        [JsonConverter(typeof(Converter.EnumToStringConverter<SubscriptionSeatType>))]
        [JsonPropertyName("seat_type")]
        public SubscriptionSeatType? SeatType { get; set; }

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

    public enum SubscriptionSeatType
    {
        SUBSCRIPTION_SEAT_TYPE_UNSPECIFIED,
        SUBSCRIPTION_SEAT_TYPE_PREMIUM,
        SUBSCRIPTION_SEAT_TYPE_COLLABORATOR,
        SUBSCRIPTION_SEAT_TYPE_LITE,
        SUBSCRIPTION_SEAT_TYPE_SERVICE_USER,
        SUBSCRIPTION_SEAT_TYPE_SUPPORT
    }
}
