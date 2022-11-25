using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Folders
{

    public class FolderResponse
    {
        [JsonPropertyName("folder")]
        public Folder Folder { get; set; } = default!;
    }
}
