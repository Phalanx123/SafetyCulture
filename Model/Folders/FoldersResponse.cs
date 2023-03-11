using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Folders
{

    public class FoldersResponse
    {
        [JsonPropertyName("folder")]
        public Folder Folder { get; set; }

        [JsonPropertyName("ancestors")]
        public List<Folder> Ancestors { get; set; }

        [JsonPropertyName("members_count")]
        public int? MembersCount { get; set; }

        [JsonPropertyName("has_children")]
        public bool? HasChildren { get; set; }
    }
}
