using Swashbuckle.AspNetCore.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DTO.MasterBarang;

namespace WebApi.ModelSampleForResponseSwagger
{
    public class CreateMasterBarangRequestExamples : IMultipleExamplesProvider<CreateMasterBarangRequest>
    {
        public IEnumerable<SwaggerExample<CreateMasterBarangRequest>> GetExamples()
        {
            yield return SwaggerExample.Create("Contoh 1",
                new CreateMasterBarangRequest
                {
                 NomorRangka ="MH8123fe12896914",
                 NomorMesin="e405id273475",
                 Merek="SUZUKI",
                 KapasitasMesin="110",
                 HargaOff=10000000,
                 BBn=2000000,
                 TahunPerakitan="2015",
                 TypeKendaraan="fu150se",
                 //UserName="",
                 //UserId=""


                });

            yield return SwaggerExample.Create("Contoh 2",
               new CreateMasterBarangRequest
               {
                   NomorRangka = "",
                   NomorMesin = "",
                   Merek = "",
                   KapasitasMesin = "",
                   HargaOff = 2000,
                   BBn = 2000,
                   TahunPerakitan = "",
                   TypeKendaraan = "",
                 //  UserName = "",
                  // UserId = ""


               });
        }
    }
}
