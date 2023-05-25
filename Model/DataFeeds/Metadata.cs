using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace SafetyCulture.Model.DataFeeds
{
	public class Metadata
	{
		[JsonPropertyName("next_page")]
		public string? NextPage { get; set; }

		[JsonPropertyName("remaining_records")]
		public int? RemainingRecords { get; set; }
	}
}
