using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using RestSharp;
using SafetyCulture.Model.Audits;

namespace SafetyCulture.Client
{
	public class AuditClient
	{
		private readonly string BearerToken;
		public  RestClient Client { get; set; }
		= new RestClient(@"https://api.safetyculture.io/");

		/// <summary>
		/// Creates an audit
		/// </summary>
		/// <param name="bearerToken"></param>
		public AuditClient(string bearerToken)
		{
			BearerToken = bearerToken;
		}

		/// <summary>
		/// Gets an audit
		/// </summary>
		/// <param name="auditID">audit_xxxxxxxxxxxxxxxxxxxx</param>
		/// <returns></returns>
		public async Task<Audit> GetAuditAsync(string auditID)
		{
			var request = new RestRequest("audits");
			request.AddHeader("Authorization", BearerToken);
			var response =await Client.ExecuteAsync(request);
			return JsonSerializer.Deserialize<Audit>(response.Content)!;
		}

		
	}
}
