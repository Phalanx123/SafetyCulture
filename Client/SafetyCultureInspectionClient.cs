using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using RestSharp;
using SafetyCulture.Interfaces;
using SafetyCulture.Model.Audits;
using SafetyCulture.Model.Configuration;

namespace SafetyCulture.Client;

public class SafetyCultureInspectionClient : ISafetyCultureInspectionClient
{
    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _jsonOptions;
    private readonly ILogger<SafetyCultureClient> _logger;

    public SafetyCultureInspectionClient(ILogger<SafetyCultureClient> logger,  HttpClient http,IOptions<SafetyCultureOptions> opts)
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

    public async Task<Inspection?> GetInspection(string auditId)
    {
        try
        {
            _logger.LogInformation("Getting inspection with Id: {AuditId}", auditId);
            var resp = await _http.GetAsync($"/inspections/v1/inspections/{auditId}");
            resp.EnsureSuccessStatusCode();
            var result = await JsonSerializer.DeserializeAsync<InspectionResponse>(
                await resp.Content.ReadAsStreamAsync(), _jsonOptions);
            if(result== null)
            {
                _logger.LogWarning("No inspection found for Id: {AuditId}", auditId);
            }
            return result?.Inspection;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting inspection with Id: {AuditId}", auditId);
            throw;
        }
    }
}