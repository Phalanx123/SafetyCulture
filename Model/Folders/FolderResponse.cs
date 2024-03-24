using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Folders
{
    /// <summary>
    /// List of Folders
    /// </summary>
    public class FoldersResponse
    {
        [JsonPropertyName("folders")]
        public List<FolderHeader> Folders { get; set; }

        [JsonPropertyName("next_page_token")]
        public string NextPageToken { get; set; }

        //[JsonPropertyName("folders_with_ancestors")]
        //public List<FolderWithAncestor> FoldersWithAncestors { get; set; }

        [JsonPropertyName("folders_enabled")]
        public bool? FoldersEnabled { get; set; }
        
        [JsonPropertyName("folder_count")]
        public int? FolderCount { get; set; }
    }

    /// <summary>
    /// When returning a single folder
    /// </summary>
    public class FolderResponse
    {
        [JsonPropertyName("folder")]
        public Folder Folder { get; set; }
    }

    public class FolderHeader
    {
        [JsonPropertyName("folder")]
        public Folder Folder { get; set; }

        [JsonPropertyName("ancestors")]
        public List<FolderWithAncestor> Ancestors { get; set; }

        [JsonPropertyName("members_count")]
        public int? MembersCount { get; set; }

        [JsonPropertyName("has_children")]
        public bool? HasChildren { get; set; }
    }
}
