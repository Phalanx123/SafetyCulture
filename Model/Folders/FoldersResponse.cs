using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

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
