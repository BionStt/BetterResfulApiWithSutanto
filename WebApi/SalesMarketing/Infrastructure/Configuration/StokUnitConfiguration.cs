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
    public class StokUnitConfiguration : IEntityTypeConfiguration<StokUnit>
    {
        public void Configure(EntityTypeBuilder<StokUnit> builder)
        {
            builder.ToTable("StokUnit");
            builder.HasKey(e => e.StokUnitId);

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();
        }
    }
}
