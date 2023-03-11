using RestSharp;
using SafetyCulture.Model.Audits;
using System.Text.Json;

namespace SafetyCulture.Client
{
    public class SafetyCultureClient
    {
        private readonly string BearerToken;
        public RestClient Client { get; set; }
        = new RestClient(@"https://api.safetyculture.io/");

        /// <summary>
        /// Creates an audit
        /// </summary>
        /// <param name="bearerToken"></param>
        public SafetyCultureClient(string bearerToken)
        {
            BearerToken = bearerToken;
            Client.AddDefaultHeader("Authorization", BearerToken);
        }

        /// <summary>
        /// Gets an audit
        /// </summary>
        /// <param name="auditID">audit_xxxxxxxxxxxxxxxxxxxx</param>
        /// <returns></returns>
        public async Task<Audit> GetAuditAsync(string auditID)
        {
            var request = new RestRequest("audits");
            var response = await Client.ExecuteAsync(request);
            return JsonSerializer.Deserialize<Audit>(response.Content)!;
        }

        public async Task<List<Model.Folders.FolderResponse>> GetFoldersAsync()
        {
            var request = new RestRequest("directory/v1/folders");
            var response = await Client.ExecuteAsync(request);
            return JsonSerializer.Deserialize<List<Model.Folders.FolderResponse>>(response.Content);
        }

    }
}
