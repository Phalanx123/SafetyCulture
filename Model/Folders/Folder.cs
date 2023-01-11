using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.Folders
{
    public class Folder
    {
        /// <summary>
        /// Unique ID
        /// </summary>
        [JsonPropertyName("id")]
        public Guid Id { get; set; }
        /// <summary>
        /// Name of the Site
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; } = default!;
        /// <summary>
        /// Organisational ID
        /// </summary>
        [JsonPropertyName("org_id")]
        public Guid OrgId { get; set; }
        /// <summary>
        /// Creator ID
        /// </summary>
        [JsonPropertyName("creator_id")]
        public Guid CreatorId { get; set; }
        /// <summary>
        /// Created on this Date
        /// </summary>
        [JsonPropertyName("created_at")]
        public DateTime CreatedAt { get; set; }

        /// <summary>
        /// Modified on this date
        /// </summary>
        [JsonPropertyName("modified_at")]
        public DateTime ModifiedAt { get; set; }
        /// <summary>
        /// Location/Region/Area
        /// </summary>
        [JsonPropertyName("meta_label")]
        public string MetaLabel { get; set; } = default!;

        [JsonPropertyName("members_count")]
        public int MembersCount { get; set; }

        [JsonPropertyName("deleted")]
        public bool Deleted { get; set; }

    }
}
