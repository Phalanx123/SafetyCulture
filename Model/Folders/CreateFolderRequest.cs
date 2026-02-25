using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Folders;

public record CreateFolderRequest
{
    [JsonPropertyName("name")]
    public required string Name { get; init; }
    [JsonPropertyName("parent_id")]
    public required Guid ParentId { get; init; }
    [JsonPropertyName("meta_label")]
    public required string MetaLabel { get; init; }
}