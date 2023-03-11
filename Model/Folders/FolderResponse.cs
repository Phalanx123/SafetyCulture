using System.Text.Json.Serialization;

namespace SafetyCulture.Model.Folders
{

    public class FolderResponse
    {
        [JsonPropertyName("folder")]
        public Folder Folder { get; set; } = default!;
    }
}
