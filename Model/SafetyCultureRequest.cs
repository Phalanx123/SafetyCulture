using SafetyCulture.Model.Incidents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model
{
    public class SafetyCultureRequest
    {
        public int? PageSize { get; set; } = 100;
        public string PageToken { get; set; }
        public string SortField { get; set; } = "SORT_FIELD_UNKNOWN";
        public string SortDirection { get; set; } = "SORT_DIRECTION_UNKNOWN";
        public Filter[] Filters { get; set; }

    }
    public class Filter
    {
            [JsonPropertyName("status_id")]
            public Guid StatusId { get; set; }

            [JsonPropertyName("priority_id")]
            public Guid PriorityId { get; set; }

            [JsonPropertyName("category_id")]
            public string CategoryId { get; set; }

            [JsonPropertyName("site_id")]
            public Guid SiteId { get; set; }

            [JsonPropertyName("assignee_id")]
            public Guid AssigneeId { get; set; }

            [JsonPropertyName("creator_id")]
            public Guid CreatorId { get; set; }

            [JsonPropertyName("title")]
            public string? Title { get; set; }

            [JsonPropertyName("description")]
            public string? Description { get; set; }

            [JsonPropertyName("task_id")]
            public Guid TaskId { get; set; }

            [JsonPropertyName("due_at")]
            public DateTime DueAt { get; set; }

            [JsonPropertyName("created_at")]
            public DateTime CreatedAt { get; set; }
        }
    
}
