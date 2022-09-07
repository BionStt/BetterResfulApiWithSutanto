using AuditLogging.Domain;
using AuditLogging.Services.Specifications.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogging.Services.Specifications
{
    public class AuditPagingSpec : BaseSpecification<AuditLogEntity>
    {
        public AuditPagingSpec(int pageSize, int offset) : base()
        {
            ApplyPaging(offset, pageSize);
           // ApplyOrderByDescending(p => p.EventTimeUtc);
            ApplyOrderByDescending(p => p.CreatedTime);
        }
    }
}
