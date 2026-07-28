using System.Net.Http.Headers;
using System.Text.Json;
using System.Text.Json.Serialization;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using SafetyCulture.Interfaces;
using SafetyCulture.Model.Configuration;
using SafetyCulture.Model.Templates;

namespace SafetyCulture.Client;

public class SafetyCultureTemplateClient : ISafetyCultureTemplateClient
{
    private readonly HttpClient _http;
    private readonly JsonSerializerOptions _jsonOptions;
    private readonly ILogger<SafetyCultureTemplateClient> _logger;

    public SafetyCultureTemplateClient(ILogger<SafetyCultureTemplateClient> logger, HttpClient http,
        IOptions<SafetyCultureOptions> opts)
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

    public async Task<SafetyCultureTemplateDetail?> GetTemplateByInspection(string inspectionId)
    {
        try
        {
            _logger.LogInformation("Getting template for inspection with Id: {InspectionId}", inspectionId);
            var resp = await _http.GetAsync($"/templates/v1/templates/inspections/{inspectionId}");
            resp.EnsureSuccessStatusCode();
            var result = await JsonSerializer.DeserializeAsync<GetTemplateByInspectionResponse>(
                await resp.Content.ReadAsStreamAsync(), _jsonOptions);
            if (result == null)
            {
                _logger.LogWarning("No template found for inspection with Id: {InspectionId}", inspectionId);
            }

            return result?.Template;
        }
        catch (Exception ex)
        {
            _logger.LogError(ex, "Error getting template for inspection with Id: {InspectionId}", inspectionId);
            throw;
        }
    }
}
