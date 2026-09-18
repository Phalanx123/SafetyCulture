using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Incidents
{
    // Root myDeserializedClass = JsonSerializer.Deserialize<Root>(myJsonResponse);
    public class Category
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("key")]
        public string Key { get; set; }

        [JsonPropertyName("label")]
        public string Label { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("display_order")]
        public int? DisplayOrder { get; set; }

        [JsonPropertyName("is_visible")]
        public bool? IsVisible { get; set; }

        [JsonPropertyName("use_category_access_whitelist")]
        public bool? UseCategoryAccessWhitelist { get; set; }

        [JsonPropertyName("items")]
        public List<object> Items { get; set; } = [];
    }

    public class Collaborator
    {
        [JsonPropertyName("collaborator_id")]
        public string CollaboratorId { get; set; } = string.Empty;

        [JsonPropertyName("collaborator_type")]
        public string CollaboratorType { get; set; } = string.Empty;

        [JsonPropertyName("assigned_role")]
        public string AssignedRole { get; set; } = string.Empty;

        [JsonPropertyName("contributor")]
        public Contributor Contributor { get; set; }
    }

    public class Contributor
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("contact")]
        public string Contact { get; set; } = string.Empty;
    }

    public class Creator
    {
        [JsonPropertyName("user_id")]
        public string UserId { get; set; }

        [JsonPropertyName("firstname")]
        public string Firstname { get; set; }

        [JsonPropertyName("lastname")]
        public string Lastname { get; set; }
    }

    public class GeoPosition
    {
        [JsonPropertyName("longitude")]
        public double? Longitude { get; set; }

        [JsonPropertyName("latitude")]
        public double? Latitude { get; set; }

        [JsonPropertyName("accuracy")]
        public int? Accuracy { get; set; }
    }

    public class Incident
    {
        [JsonPropertyName("task")]
        public IssueTask Task { get; set; }

        [JsonPropertyName("category_id")]
        public string CategoryId { get; set; } = string.Empty;

        [JsonPropertyName("category")]
        public Category Category { get; set; }

        [JsonPropertyName("media")]
        public List<Medium> Media { get; set; } = [];

        [JsonPropertyName("location")]
        public Location Location { get; set; }

        [JsonPropertyName("inspections")]
        public List<object> Inspections { get; set; } = [];
    }

    public class Inspection
    {
        [JsonPropertyName("inspection_id")]
        public string InspectionId { get; set; } = string.Empty;

        [JsonPropertyName("inspection_name")]
        public string InspectionName { get; set; } = string.Empty;
    }

    public class InspectionItem
    {
        [JsonPropertyName("inspection_item_id")]
        public string InspectionItemId { get; set; } = string.Empty;

        [JsonPropertyName("inspection_item_name")]
        public string InspectionItemName { get; set; } = string.Empty;

        [JsonPropertyName("inspection_item_type")]
        public string InspectionItemType { get; set; } = string.Empty;

        [JsonPropertyName("inspection_item_response_values")]
        public List<object> InspectionItemResponseValues { get; set; } = [];
    }

    public class Location
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("thoroughfare")]
        public string Thoroughfare { get; set; } = string.Empty;

        [JsonPropertyName("sub_thoroughfare")]
        public string SubThoroughfare { get; set; } = string.Empty;

        [JsonPropertyName("locality")]
        public string Locality { get; set; } = string.Empty;

        [JsonPropertyName("sub_locality")]
        public string SubLocality { get; set; } = string.Empty;

        [JsonPropertyName("administrative_area")]
        public string AdministrativeArea { get; set; } = string.Empty;

        [JsonPropertyName("sub_administrative_area")]
        public string SubAdministrativeArea { get; set; } = string.Empty;

        [JsonPropertyName("postal_code")]
        public string PostalCode { get; set; } = string.Empty;

        [JsonPropertyName("country")]
        public string Country { get; set; } = string.Empty;

        [JsonPropertyName("iso_country_code")]
        public string IsoCountryCode { get; set; } = string.Empty;

        [JsonPropertyName("geo_position")]
        public GeoPosition GeoPosition { get; set; }
    }

    public class Medium
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("token")]
        public string Token { get; set; } = string.Empty;

        [JsonPropertyName("filename")]
        public string Filename { get; set; } = string.Empty;

        [JsonPropertyName("media_type")]
        public string MediaType { get; set; } = string.Empty;
    }

    public class IncidentRoot
    {
        [JsonPropertyName("incidents")]
        public List<Incident> Incidents { get; set; } = [];
        
        [JsonPropertyName("next_page_token")]
        public string NextPageToken { get; set; } = string.Empty;

        [JsonPropertyName("total")]
        public int? Total { get; set; }
    }

    public class Site
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("region")]
        public string Region { get; set; } = string.Empty;

        [JsonPropertyName("area")]
        public string Area { get; set; } = string.Empty;
    }

    public class IssueTask
    {
        [JsonPropertyName("task_id")]
        public string TaskId { get; set; } = string.Empty;

        [JsonPropertyName("creator")]
        public Creator Creator { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime? CreatedAt { get; set; }

        [JsonPropertyName("due_at")]
        public DateTime? DueAt { get; set; }

        [JsonPropertyName("priority_id")]
        public string PriorityId { get; set; } = string.Empty;

        [JsonPropertyName("status_id")]
        public string StatusId { get; set; } = string.Empty;

        [JsonPropertyName("collaborators")]
        public List<Collaborator> Collaborators { get; set; } = [];

        [JsonPropertyName("template_id")]
        public string TemplateId { get; set; } = string.Empty;

        [JsonPropertyName("inspection")]
        public Inspection Inspection { get; set; }

        [JsonPropertyName("inspection_item")]
        public InspectionItem InspectionItem { get; set; }

        [JsonPropertyName("site")]
        public Site Site { get; set; }

        [JsonPropertyName("modified_at")]
        public DateTime? ModifiedAt { get; set; }

        [JsonPropertyName("references")]
        public List<object> References { get; set; } = [];

        [JsonPropertyName("completed_at")]
        public DateTime? CompletedAt { get; set; }

        [JsonPropertyName("template_name")]
        public string TemplateName { get; set; }

        [JsonPropertyName("status")]
        public object Status { get; set; }

        [JsonPropertyName("asset_id")]
        public string AssetId { get; set; } = string.Empty;

        [JsonPropertyName("asset")]
        public object Asset { get; set; }

        [JsonPropertyName("action_label")]
        public List<object> ActionLabel { get; set; } = [];

        [JsonPropertyName("unique_id")]
        public string UniqueId { get; set; } = string.Empty;

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }

}
