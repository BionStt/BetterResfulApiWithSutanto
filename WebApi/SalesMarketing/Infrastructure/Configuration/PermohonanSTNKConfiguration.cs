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
    public class PermohonanSTNKConfiguration : IEntityTypeConfiguration<PermohonanSTNK>
    {
        public void Configure(EntityTypeBuilder<PermohonanSTNK> builder)
        {
            builder.ToTable("PermohonanSTNK");
            builder.HasKey(e => e.PermohonanSTNKId);

            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(x => x.BbnPabrik).HasColumnType("money");
            builder.Property(x => x.BiayaTambahan).HasColumnType("money");
            builder.Property(x => x.Birojasa).HasColumnType("money");
            builder.Property(x => x.FormA).HasColumnType("money");
            builder.Property(x => x.PajakProgresif).HasColumnType("money");
            builder.Property(x => x.PajakStnk).HasColumnType("money");
            builder.Property(x => x.Perwil).HasColumnType("money");


        }
    }
}
