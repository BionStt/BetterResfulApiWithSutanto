using AuditLogging.Data.Context;
using AuditLogging.Domain;
using AuditLogging.Services.Repository.Contract;
using AuditLogging.Services.Specifications.Base;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogging.Services.Repository.Implementation
{
    public class AuditLogRepository : IAuditLogRepository
    {
        protected readonly AuditLogContext DbContext;

        public AuditLogRepository(AuditLogContext dbContext)
        {
            DbContext = dbContext;
        }

        private IQueryable<AuditLogEntity> ApplySpecification(ISpecification<AuditLogEntity> spec)
        {
            return SpecificationEvaluator<AuditLogEntity>.GetQuery(DbContext.Set<AuditLogEntity>().AsQueryable(), spec);
        }
        public async Task<AuditLogEntity> AddAsync(AuditLogEntity entity)
        {
            await DbContext.Set<AuditLogEntity>().AddAsync(entity);
            await DbContext.SaveChangesAsync();

            return entity;
        }

        public async Task<IReadOnlyList<AuditLogEntity>> GetAsync(ISpecification<AuditLogEntity> spec)
        {
            return await ApplySpecification(spec).AsNoTracking().ToListAsync();
        }

        public int Count(ISpecification<AuditLogEntity> spec = null)
        {
            return null != spec ? ApplySpecification(spec).Count() : DbContext.Set<AuditLogEntity>().Count();
        }

        public async Task ExecuteSqlRawAsync(string sql)
        {
            await DbContext.Database.ExecuteSqlRawAsync(sql);
        }
    }
}
