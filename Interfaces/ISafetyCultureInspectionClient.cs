using SafetyCulture.Model.Audits;

namespace SafetyCulture.Interfaces;

public interface ISafetyCultureInspectionClient
{
    /// <summary>
    /// Gets an inspection by its audit ID.
    /// </summary>
    /// <param name="auditId"></param>
    /// <returns></returns>
    Task<Inspection?> GetInspection(string auditId);
}