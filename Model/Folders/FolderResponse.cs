using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Folders
{
    /// <summary>
    /// List of Folders
    /// </summary>
    public class FoldersResponse
    {
        [JsonPropertyName("folders")]
        public List<Folder> Folders { get; set; }

        [JsonPropertyName("next_page_token")]
        public string NextPageToken { get; set; }

        [JsonPropertyName("folders_with_ancestors")]
        public List<FolderWithAncestor> FoldersWithAncestors { get; set; }

        [JsonPropertyName("folders_enabled")]
        public bool? FoldersEnabled { get; set; }
    }

    /// <summary>
    /// When returning a single folder
    /// </summary>
    public class FolderResponse
    {
        [JsonPropertyName("folder")]
        public Folder Folder { get; set; }
    }
}
