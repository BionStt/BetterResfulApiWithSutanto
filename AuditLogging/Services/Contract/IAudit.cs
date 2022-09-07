using AuditLogging.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogging.Services.Contract
{
    public interface IAudit
    {
        Task AddAuditLogging(DateTime? logStartTime, string errorMessage, string uniqueId, string action, string data, int? createdBy, DateTime createdTime, string requestStatus, int? stage, string userName, string ipV4);

        Task<(IReadOnlyList<AuditLogEntity> Entries, int Count)> GetAuditEntries(int skip, int take);

        Task ClearAuditLog();
    }
}
