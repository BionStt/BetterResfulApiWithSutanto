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
    public class DataSalesMarketingConfiguration : IEntityTypeConfiguration<DataSalesMarketing>
    {
        public void Configure(EntityTypeBuilder<DataSalesMarketing> builder)
        {
            builder.ToTable("DataSalesMarketing");
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();


        }
    }
}
