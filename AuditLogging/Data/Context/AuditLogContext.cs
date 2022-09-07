using AuditLogging.Data.Configuration;
using AuditLogging.Domain;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AuditLogging.Data.Context
{
    public class AuditLogContext: DbContext
    {
        public AuditLogContext()
        {

        }
        public AuditLogContext(DbContextOptions<AuditLogContext> options) : base(options)
        {

        }
        public virtual DbSet<AuditLogEntity> AuditLog { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.ApplyConfiguration(new AuditLogConfiguration());
        }


    }
}
