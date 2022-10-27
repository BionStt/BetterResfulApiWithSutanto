using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.DTO.MasterBarang;
using WebApi.SalesMarketing.ServiceApplication.MasterBarang.Commands.CreateMasterBarang;

namespace WebApi.DTOMapping
{
    public static class MasterBarangRequestMappingConfiguration
    {
        public static CreateMasterBarangCommand ToCommand(this CreateMasterBarangRequest model)
        {
            return new CreateMasterBarangCommand
            {
                BBn = model.BBn,
                HargaOff = model.HargaOff,
                KapasitasMesin = model.KapasitasMesin,
                Merek = model.Merek,
                NamaBarang = model.NamaBarang,
                NomorMesin = model.NomorMesin,
                NomorRangka = model.NomorRangka,
                TahunPerakitan = model.TahunPerakitan,
                TypeKendaraan = model.TypeKendaraan,
               // UserName = model.UserName,
               // USerNameId = Guid.Parse(model.UserId)
            };
        }
    }
}
