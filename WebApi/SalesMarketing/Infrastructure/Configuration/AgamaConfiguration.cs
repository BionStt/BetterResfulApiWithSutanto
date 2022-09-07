using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Domain.EnumInEntity;

namespace WebApi.SalesMarketing.Infrastructure.Configuration
{
    public class AgamaConfiguration : IEntityTypeConfiguration<Agama>
    {
        public void Configure(EntityTypeBuilder<Agama> builder)
        {
            builder.ToTable("Agama");
            builder.HasKey(e => e.AgamaId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            //builder.HasData(
            //   Agama.AddAgama("ISLAM"),
            //    Agama.AddAgama("HINDU"),
            //     Agama.AddAgama("KRISTEN"),
            //      Agama.AddAgama("KATOLIK"),
            //       Agama.AddAgama("BUDDHA"),
            //        Agama.AddAgama("KONGHUCU")
            //   );


        }
    }
}
