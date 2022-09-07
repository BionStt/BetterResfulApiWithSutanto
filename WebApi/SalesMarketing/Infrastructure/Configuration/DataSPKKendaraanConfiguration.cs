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
    public class DataSPKKendaraanConfiguration : IEntityTypeConfiguration<DataSPKKendaraan>
    {
        public void Configure(EntityTypeBuilder<DataSPKKendaraan> builder)
        {
            builder.ToTable("DataSPKKendaraan");
            builder.HasKey(e => e.DataSPKKendaraanId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            builder.Property(e => e.TahunPerakitan).HasMaxLength(5).IsUnicode(false);
            builder.Property(e => e.Warna).HasMaxLength(25).IsUnicode(false);
            builder.Property(e => e.NamaSTNK).HasMaxLength(35).IsUnicode(false);
            builder.Property(e => e.NoKtpSTNK).HasMaxLength(25);



        }
    }
}