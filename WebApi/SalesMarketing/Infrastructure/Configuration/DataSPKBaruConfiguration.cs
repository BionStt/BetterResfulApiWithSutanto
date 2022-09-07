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
    public class DataSPKBaruConfiguration : IEntityTypeConfiguration<DataSPK>
    {
        public void Configure(EntityTypeBuilder<DataSPK> builder)
        {
            builder.ToTable("DataSPK");
            builder.HasKey(e => e.DataSPKId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.LokasiSpk).HasMaxLength(50).IsUnicode(false);
            builder.Property(e => e.NoRegistrasiSPK).HasMaxLength(25);
            builder.Property(e => e.TanggalInput).HasColumnType("datetime").HasDefaultValueSql("GetDate()");

            //var converterStatus = new EnumToStringConverter<StatusSPK>();
            //builder.Property(e => e.StatusSPK).HasConversion(converterStatus);

        }
    }
}
