using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SafetyCulture.Interfaces;
using SafetyCulture.Model.Configuration;
using SafetyCulture.Model.InspectionDetails;

namespace SafetyCulture.Client;

public class SafetyCultureInspectionDetailsClient : ISafetyCultureInspectionDetailsClient
{
    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _jsonOptions;
    private readonly ILogger<SafetyCultureInspectionDetailsClient> _logger;

    public SafetyCultureInspectionDetailsClient(ILogger<SafetyCultureInspectionDetailsClient> logger, HttpClient http, IOptions<SafetyCultureOptions> opts)
    {
        _http = http;
        _http.BaseAddress = new Uri(opts.Value.BaseUrl);
        _http.DefaultRequestHeaders.Authorization =
            new AuthenticationHeaderValue("Bearer", opts.Value.BearerToken);
        _jsonOptions = new JsonSerializerOptions
        {
            DefaultIgnoreCondition = JsonIgnoreCondition.WhenWritingDefault
        };
        _logger = logger;
    }

    public async Task<InspectionDetailsInspection?> GetInspectionDetails(string auditId)
    {
        try
        {
            _logger.LogInformation("Getting inspection details for Id: {AuditId}", auditId);
            var resp = await _http.GetAsync($"/inspections/v1/inspections/{auditId}/details");
            resp.EnsureSuccessStatusCode();
            var result = await JsonSerializer.DeserializeAsync<InspectionDetailsResponse>(
                await resp.Content.ReadAsStreamAsync(), _jsonOptions);
            if (result == null)
            {
                _logger.LogWarning("No inspection details found for Id: {AuditId}", auditId);
            }
            return result?.Inspection;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting inspection details for Id: {AuditId}", auditId);
            throw;
        }
    }
}
