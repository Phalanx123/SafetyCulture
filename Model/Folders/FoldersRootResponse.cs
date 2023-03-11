using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Folders
{

    public class FoldersRootResponse
    {
        [JsonPropertyName("folders")]
        public List<FoldersResponse>? Folders { get; set; }

        [JsonPropertyName("folder_count")]
        public int? FolderCount { get; set; }

        [JsonPropertyName("next_page_token")]
        public string? NextPageToken { get; set; }

        [JsonPropertyName("folders_enabled")]
        public bool? FoldersEnabled { get; set; }
    }
}
