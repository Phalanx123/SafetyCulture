using RestSharp;
using SafetyCulture.Model.Webhooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace SafetyCulture.Client
{
    public class WebhookClient
    {
		private readonly string BearerToken;
		public RestClient Client { get; set; }
		= new RestClient(@"https://api.safetyculture.io/");

		/// <summary>
		/// Creates an audit
		/// </summary>
		/// <param name="bearerToken"></param>
		public WebhookClient(string bearerToken)
		{
			BearerToken = bearerToken;
		}

		/// <summary>
		/// Gets an audit
		/// </summary>
		/// <param name="auditID">audit_xxxxxxxxxxxxxxxxxxxx</param>
		/// <returns></returns>
		public async Task<Webhook> GetAuditAsync(string url, List<TriggerEvent> events)
		{
			
			var request = new RestRequest("webhooks/v1/webhooks", Method.Post);
			request.AddHeader("Authorization", BearerToken);
			var response = await Client.ExecuteAsync(request);
			return JsonSerializer.Deserialize<Webhook>(response.Content)!;
		}


	}
}
