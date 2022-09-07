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
    public class MasterLeasingConfiguration : IEntityTypeConfiguration<MasterLeasing>
    {
        public void Configure(EntityTypeBuilder<MasterLeasing> builder)
        {
            builder.ToTable("MasterLeasing");
            builder.HasKey(e => e.MasterLeasingId);

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.NamaLeasing).HasMaxLength(50)
                .IsUnicode(false);

        }
    }
}
