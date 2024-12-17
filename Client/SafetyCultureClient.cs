using OneOf;
using RestSharp;
using SafetyCulture.Converters;
using SafetyCulture.Model;
using SafetyCulture.Model.Assets;
using SafetyCulture.Model.Audits;
using SafetyCulture.Model.DataFeeds;
using SafetyCulture.Model.Folders;
using SafetyCulture.Model.Incidents;
using SafetyCulture.Model.ResponseSets;
using System.Text.Json;
using SafetyCulture.Model.Templates;

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

        public async Task<OneOf<string, ResponseError>> GetInspectionWebReportLink(string auditID)
        {
            var request = new RestRequest($"/audits/{auditID}/web_report_link");
            var response = await Client.ExecuteGetAsync(request);

            if (response is { IsSuccessful: true, Content: not null })
            {
                using var jsonDoc = JsonDocument.Parse(response.Content);
                if (jsonDoc.RootElement.TryGetProperty("url", out var urlElement) &&
                    urlElement.GetString() is { } url)
                {
                    return url;
                }

                // Attempt to deserialize the content into a ResponseError object
                var errorResponse = JsonSerializer.Deserialize<ResponseError>(response.Content);
                return errorResponse;
            }

            throw new InvalidOperationException();
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

        public async Task<List<InspectionAnswerResponse>> GetInspectionAnswersResponseAsync(string inspectionID)
        {
            var request = new RestRequest($"/inspections/v1/answers/{inspectionID}");
            var response = await Client.ExecuteGetAsync<List<InspectionAnswerResponse>>(request);
            var modified = $"[{response.Content.Replace("}\n{", "},\n{")}]";
            var result = JsonSerializer.Deserialize<List<InspectionAnswerResponse>>(modified);

            return result ?? [];
        }

        public async Task<Guid> CreateAsset(Asset asset)
        {
            var request = new RestRequest($"/assets/v1/assets");
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };
            var jsonContent = JsonSerializer.Serialize(asset, options);
            request.AddBody(jsonContent);
            var response = await Client.ExecutePostAsync<Asset>(request);
            return response.Data.Id.Value;
        }

        public async Task<Asset> UpdateAsset(Asset asset)
        {
            var request = new RestRequest($"/assets/v1/assets/{asset.Id}", Method.Patch);
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };
            asset.TypeId = default;
            var jsonContent = JsonSerializer.Serialize(asset, options);
            request.AddBody(jsonContent);
            var response = await Client.ExecuteAsync<Asset>(request);
            return response.Data;
        }

        /// <summary>
        /// Gets an audit
        /// </summary>
        /// <param name="auditID">audit_xxxxxxxxxxxxxxxxxxxx</param>
        /// <returns></returns>
        public async Task<InspectionHeaderResponse> GetInspectionsAsync(string? templateId = null,
            DateTime? modifiedAfter = null, DateTime? modifiedBefore = null)
        {
            var request = new RestRequest("audits/search");
            if (templateId != null)
                request.AddParameter("template", templateId);
            if (modifiedAfter != null)
                request.AddParameter("modified_after", modifiedAfter!.Value.ToString("o"));
            if (modifiedBefore != null)
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


        public async Task<AssetSiteUpdateResponse> UpdateSiteAssets(Guid safetyCultureFolderID,
            IEnumerable<Guid> assetIds)
        {
            var request = new RestRequest("assets/v1/assets:SetSiteForAssets", Method.Post);
            request.AddJsonBody(new { site = safetyCultureFolderID, asset_ids = assetIds });
            var response = await Client.ExecuteAsync<AssetSiteUpdateResponse>(request);
            return response.Data!;
        }

        public async Task<InspectionDataFeed> GetInspectionDataFeedAsync(DateTimeOffset? modifiedAfter,
            DateTimeOffset? modifiedBefore, bool? archived, bool? completed, bool publicWebReportLink,
            string[]? templateIds)
        {
            var request = new RestRequest("feed/inspections", Method.Get);
            if (modifiedAfter != null)
                request.AddParameter("modified_after", modifiedAfter.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            if (modifiedBefore != null)
                request.AddParameter("modified_before", modifiedBefore.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            if (templateIds != null)
                foreach (var templateId in templateIds)
                    request.AddParameter("template", templateId);
            request.AddParameter("archived", Converter.NullableBoolToStringConverter(archived));
            request.AddParameter("completed", Converter.NullableBoolToStringConverter(completed));
            request.AddParameter("web_report_link", publicWebReportLink ? "public" : "private");
            var response = await Client.ExecuteGetAsync<InspectionDataFeed>(request);
            var dataFeed = new InspectionDataFeed();
            if (response.IsSuccessful)
            {
                dataFeed = response.Data!;
            }

            while (response.IsSuccessStatusCode && response.Data!.Metadata!.RemainingRecords != 0)
            {
                request = new RestRequest(response.Data.Metadata.NextPage);
                response = await Client.ExecuteGetAsync<InspectionDataFeed>(request);
                if (response.IsSuccessful)
                    dataFeed.Data!.AddRange(response.Data!.Data!);
            }

            return dataFeed;
        }


        public async Task<TemplateDataFeed> GetTemplateDataFeedAsync(DateTimeOffset? modifiedAfter,
            DateTimeOffset? modifiedBefore, bool? archived)
        {
            var request = new RestRequest("feed/templates", Method.Get);
            if (modifiedAfter != null)
                request.AddParameter("modified_after", modifiedAfter.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            if (modifiedBefore != null)
                request.AddParameter("modified_before", modifiedBefore.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            request.AddParameter("archived", Converter.NullableBoolToStringConverter(archived));
            var response = await Client.ExecuteGetAsync<TemplateDataFeed>(request);
            var dataFeed = new TemplateDataFeed();
            if (response.IsSuccessful)
            {
                dataFeed = response.Data!;
            }

            while (response.IsSuccessStatusCode && response.Data!.Metadata!.RemainingRecords != 0)
            {
                request = new RestRequest(response.Data.Metadata.NextPage);
                response = await Client.ExecuteGetAsync<TemplateDataFeed>(request);
                if (response.IsSuccessful)
                    dataFeed.Data!.AddRange(response.Data!.Data!);
            }

            return dataFeed;
        }

        public async Task<TemplatePermissionsDataFeed> GetTemplatePermissionsDataFeedAsync(
            DateTimeOffset? modifiedAfter, DateTimeOffset? modifiedBefore, bool? archived)
        {
            var request = new RestRequest("feed/template_permissions", Method.Get);
            if (modifiedAfter != null)
                request.AddParameter("modified_after", modifiedAfter.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            if (modifiedBefore != null)
                request.AddParameter("modified_before", modifiedBefore.Value.ToString("yyyy-MM-ddTHH:mm:ssZ"));
            request.AddParameter("archived", Converter.NullableBoolToStringConverter(archived));
            var response = await Client.ExecuteGetAsync<TemplatePermissionsDataFeed>(request);
            var dataFeed = new TemplatePermissionsDataFeed();
            if (response.IsSuccessful)
            {
                dataFeed = response.Data!;
            }

            while (response.IsSuccessStatusCode && response.Data!.Metadata!.RemainingRecords != 0)
            {
                request = new RestRequest(response.Data.Metadata.NextPage);
                response = await Client.ExecuteGetAsync<TemplatePermissionsDataFeed>(request);
                if (response.IsSuccessful)
                    dataFeed.Data!.AddRange(response.Data!.Data!);
            }

            return dataFeed;
        }

        public async Task<GroupDataFeed> GetGroupDataFeedAsync()
        {
            var request = new RestRequest("feed/groups", Method.Get);
            var response = await Client.ExecuteGetAsync<GroupDataFeed>(request);
            var dataFeed = new GroupDataFeed();
            if (response.IsSuccessful)
            {
                dataFeed = response.Data!;
            }

            while (response.IsSuccessStatusCode && response.Data!.Metadata!.RemainingRecords != 0)
            {
                request = new RestRequest(response.Data.Metadata.NextPage);
                response = await Client.ExecuteGetAsync<GroupDataFeed>(request);
                if (response.IsSuccessful)
                    dataFeed.Data!.AddRange(response.Data!.Data!);
            }

            return dataFeed;
        }

        public async Task<OneOf<InspectionExportResult, ResponseError>> ExportInspection(InspectionExport export)
        {
            var request = new RestRequest($"/inspection/v1/export", Method.Post);
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };
            var jsonContent = JsonSerializer.Serialize(export, options);
            request.AddBody(jsonContent);
            var response = await Client.ExecuteAsync(request);
            if ((int)response.StatusCode >= 200 && (int)response.StatusCode <= 299)
            {
                var data = JsonSerializer.Deserialize<InspectionExportResult>(response.Content);
                return data;
            }

            var error = JsonSerializer.Deserialize<ResponseError>(response.Content);
            return error;
        }


        public async Task<OneOf<ResponseSetItem, ResponseError>> UpdateGlobalResponseSetResponse(string id,
            string responseId, ResponseSetItem responseSet)
        {
            var request = new RestRequest($"/response_sets/{id}/responses/{responseId}", Method.Put);
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };
            var jsonContent = JsonSerializer.Serialize(responseSet, options);
            request.AddBody(jsonContent);
            var response = await Client.ExecuteAsync(request);
            if ((int)response.StatusCode >= 200 && (int)response.StatusCode <= 299)
            {
                var data = JsonSerializer.Deserialize<ResponseSetItemsResponse>(response.Content);
                return data.ResponseSet;
            }

            var error = JsonSerializer.Deserialize<ResponseError>(response.Content);
            return error;
        }

        public async Task<OneOf<ResponseSetResponse, ResponseError>> UpdateGlobalResponseSet(string id,
            IEnumerable<ResponseSetItem> responseSets)
        {
            return await UpdateGlobalResponseSet(id, new ResponseSet
            {
                Responses = responseSets.ToList()
            });
        }

        public async Task<OneOf<ResponseSetResponse, ResponseError>> UpdateGlobalResponseSet(string id,
            ResponseSet responseSet)
        {
            var request = new RestRequest($"/response_sets/{id}", Method.Put);
            var options = new JsonSerializerOptions
            {
                DefaultIgnoreCondition = System.Text.Json.Serialization.JsonIgnoreCondition.WhenWritingDefault
            };
            var jsonContent = JsonSerializer.Serialize(responseSet, options);
            request.AddBody(jsonContent);
            var response = await Client.ExecuteAsync(request);
            if ((int)response.StatusCode >= 200 && (int)response.StatusCode <= 299)
            {
                var data = JsonSerializer.Deserialize<ResponseSetResponse>(response.Content);
                return data;
            }

            var error = JsonSerializer.Deserialize<ResponseError>(response.Content);
            return error;
        }

        public async Task<OneOf<List<SafetyCultureTemplate>, ResponseError>> GetTemplatesAsync(
            SafetyCultureTemplateFilter filter)
        {
            var request = new RestRequest($"/templates/search", Method.Get);
            if (filter.Limit != default)
                request.AddQueryParameter("limit", filter.Limit);
            if (filter.Order != default)
                request.AddQueryParameter("order", filter.Order.Value.ToString().ToLower());
            if (filter.ModifiedAfter != default)
                request.AddQueryParameter("modified_after", filter.ModifiedAfter.Value.ToString("yyyy-MM-dddd"));
            if (filter.ModifiedBefore != default)
                request.AddQueryParameter("modified_before", filter.ModifiedBefore.Value.ToString("yyyy-MM-dddd"));
            if (filter.Archived != default)
                request.AddQueryParameter("archived", filter.Archived.ToString().ToLower());
            if (filter.Owner != default)
                request.AddQueryParameter("owner", filter.Owner.Value.ToString().ToLower());

            var response = await Client.ExecuteAsync(request);
            if ((int)response.StatusCode >= 200 && (int)response.StatusCode <= 299)
            {
                var data = JsonSerializer.Deserialize<SafetyCultureTemplateResponse>(response.Content);
                return data.Templates.ToList();
            }

            var error = JsonSerializer.Deserialize<ResponseError>(response.Content);
            return error;
        }

        public async Task<OneOf<IncidentRoot, ResponseError>> GetIncidentsAsync(
            SafetyCultureRequest safetyCultureRequest)
        {
            var allIncidents = new IncidentRoot
            {
                Incidents = []
            };

            string? pageToken = null;

            do
            {
                var request = new RestRequest($"/tasks/v1/incidents/list");
                if (pageToken is not null)
                    request.AddParameter("page_token", pageToken);

                var response = await Client.ExecutePostAsync<IncidentRoot>(request);

                if ((int)response.StatusCode >= 200 && (int)response.StatusCode <= 299)
                {
                    allIncidents.Incidents.AddRange(response.Data.Incidents);
                    pageToken = response.Data.NextPageToken;
                }
                else
                {
                    var error = JsonSerializer.Deserialize<ResponseError>(response.Content);
                    return error;
                }
            } while (!string.IsNullOrEmpty(pageToken));

            return allIncidents;
        }

        public async Task<bool> CreateGlobalResponseSetResponse(string responseSetId, string label, string shortLabel)
        {
            try
            {
                var request = new RestRequest($"/response_sets/{responseSetId}/responses", Method.Post);
                var payload = new
                {
                    label,
                    short_label = shortLabel // Correct property name in the JSON payload
                };

                // Serialize payload using System.Text.Json
                var jsonOptions = new JsonSerializerOptions
                {
                    PropertyNamingPolicy = JsonNamingPolicy.SnakeCaseLower
                };
                var jsonBody = JsonSerializer.Serialize(payload, jsonOptions);

                // Add JSON body
                request.AddStringBody(jsonBody, DataFormat.Json);

                // Execute the request asynchronously
                var response = await Client.ExecuteAsync(request);

                // Check for success
                return response.IsSuccessful;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<bool> DeleteGlobalResponseSetResponse(string responseSetId, string? responseId)
        {
            try
            {
                var request = new RestRequest($"/response_sets/{responseSetId}/responses/{responseId}", Method.Delete);

                // Execute the request asynchronously
                var response = await Client.ExecuteAsync(request);

                // Check for success
                return response.IsSuccessful;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<ResponseSet?> GetGlobalResponseSet(string responseSetId)
        {
            var request = new RestRequest($"response_sets/{responseSetId}");
            var result = await Client.ExecuteAsync<ResponseSet>(request);
            if (result.IsSuccessful)
                return result.Data;
            throw new Exception("Failed to get response set");
        }
    }
}