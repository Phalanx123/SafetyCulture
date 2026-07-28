using SafetyCulture.Model.InspectionDetails;

namespace SafetyCulture.Interfaces;

public interface ISafetyCultureInspectionDetailsClient
{
    /// <summary>
    /// Gets the full item-tree detail for an inspection by its audit ID.
    /// </summary>
    /// <param name="auditId"></param>
    Task<InspectionDetailsInspection?> GetInspectionDetails(string auditId);
}
