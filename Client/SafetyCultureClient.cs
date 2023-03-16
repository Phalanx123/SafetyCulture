using RestSharp;
using SafetyCulture.Model.Audits;
using SafetyCulture.Model.Folders;
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
        public async Task<AuditLegacy> GetAuditLegacyAsync(string auditID)
        {
            var request = new RestRequest($"/audits/{auditID}");

            var response = await Client.ExecuteGetAsync<AuditLegacy>(request);

            return response.Data;
        }



        /// <summary>
        /// Gets an audit
        /// </summary>
        /// <param name="inspectionID">audit_xxxxxxxxxxxxxxxxxxxx</param>
        /// <returns></returns>
        public async Task<InspectionResponse> GetInspectionAsync(string inspectionID)
        {
            var request = new RestRequest($"/inspections/v1/inspections/{inspectionID}");

            var response = await Client.ExecuteGetAsync<InspectionResponse>(request);

            return response.Data;
        }

        public async Task<InspectionAnswersResponse> GetInspectionAnswersResponseAsync(string inspectionID)
        {
            var request = new RestRequest($"/inspections/v1/answers/{inspectionID}");
            var response = await Client.ExecuteGetAsync<InspectionAnswersResponse>(request);
            var text = response.Content.Replace("\"result\":", "").Replace("}\n{",",");
            text = "{\n \"result\": \n[" + text.Substring(1, text.Length - 3) + "]\n}";
            var result =  JsonSerializer.Deserialize<InspectionAnswersResponse>(text);
            return result;
        }

        /// <summary>
        /// Gets an audit
        /// </summary>
        /// <param name="auditID">audit_xxxxxxxxxxxxxxxxxxxx</param>
        /// <returns></returns>
        public async Task<InspectionHeaderResponse> GetInspectionsAsync(string? templateId = null, DateTime? modifiedAfter = null, DateTime? modifiedBefore = null)
        {
            var request = new RestRequest("audits/search");
            if (templateId != null)
                request.AddParameter("template", templateId);
            if (modifiedAfter != null)
                request.AddParameter("modified_after", modifiedAfter!.Value.ToString("o"));
                if(modifiedBefore !=null)
                request.AddParameter("modified_before", modifiedBefore!.Value.ToString("o"));
            var response = await Client.ExecuteAsync<InspectionHeaderResponse>(request);
            return response.Data;
        }

        public async Task<FoldersResponse> GetFoldersAsync(bool withAncestors = true)
        {
            var request = new RestRequest("directory/v1/folders");
            request.AddParameter("with_ancestors", withAncestors);
            var result = await Client.ExecuteAsync<FoldersResponse>(request);
            return result.Data;

        }

        public async Task PostInspectionSiteAsync(string inspectionId, string siteId)
        {
            var request = new RestRequest($"inspections/v1/inspections/{inspectionId}/site", Method.Put);
            request.AddJsonBody(new { site_id = siteId });
            var response = await Client.ExecuteAsync(request);
        }
    }
}
