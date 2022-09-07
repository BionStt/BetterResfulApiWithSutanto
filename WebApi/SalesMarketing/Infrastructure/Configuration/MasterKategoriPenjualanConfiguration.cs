﻿using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Domain;

namespace WebApi.SalesMarketing.Infrastructure.Configuration
{
    public class MasterKategoriPenjualanConfiguration : IEntityTypeConfiguration<MasterKategoriPenjualan>
    {
        public void Configure(EntityTypeBuilder<MasterKategoriPenjualan> builder)
        {
            builder.ToTable("MasterKategoriPenjualan");
            builder.HasKey(e => e.MasterKategoriPenjualanId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.NamaKategoryPenjualan)
                .HasMaxLength(50)
                .IsUnicode(false);

        }
    }
}
