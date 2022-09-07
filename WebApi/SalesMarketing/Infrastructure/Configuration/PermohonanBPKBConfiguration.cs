using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Domain;

namespace WebApi.SalesMarketing.Infrastructure.Configuration
{
    public class PermohonanBPKBConfiguration : IEntityTypeConfiguration<PermohonanBPKB>
    {
        public void Configure(EntityTypeBuilder<PermohonanBPKB> builder)
        {
            builder.ToTable("PermohonanBPKB");
            builder.HasKey(e => e.PermohonanBPKBId);

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

        }
    }
}
