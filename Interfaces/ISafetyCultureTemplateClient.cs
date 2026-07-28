using SafetyCulture.Model.Templates;

namespace SafetyCulture.Interfaces;

public interface ISafetyCultureTemplateClient
{
    /// <summary>
    /// Gets the template used by a given inspection.
    /// Endpoint: GET /templates/v1/templates/inspections/{inspection_id}
    /// </summary>
    /// <param name="inspectionId">The ID of the inspection whose template should be returned.</param>
    /// <returns></returns>
    Task<SafetyCultureTemplateDetail?> GetTemplateByInspection(string inspectionId);
}
