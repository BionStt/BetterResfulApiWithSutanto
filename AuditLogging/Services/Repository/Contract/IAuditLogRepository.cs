using AuditLogging.Domain;
using AuditLogging.Services.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogging.Services.Repository.Contract
{
    public interface IAuditLogRepository
    {
        Task<AuditLogEntity> AddAsync(AuditLogEntity entity);

        Task<IReadOnlyList<AuditLogEntity>> GetAsync(ISpecification<AuditLogEntity> spec);

        int Count(ISpecification<AuditLogEntity> spec = null);

        Task ExecuteSqlRawAsync(string sql);
    }
}
