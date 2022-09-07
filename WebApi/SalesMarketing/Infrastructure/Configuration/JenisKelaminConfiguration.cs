using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.Infrastructure.Configuration
{
    public class JenisKelaminConfiguration : IEntityTypeConfiguration<JenisKelamin>
    {
        public void Configure(EntityTypeBuilder<JenisKelamin> builder)
        {
            builder.ToTable("JenisKelamin");
            builder.HasKey(e => e.JenisKelaminId);
            builder.Property(e => e.NoUrutId).ValueGeneratedOnAdd();

            //builder.HasData(
            //    JenisKelamin.AddJenisKelamin("PRIA"),
            //    JenisKelamin.AddJenisKelamin("WANITA")
            //    );
        }
    }
}
