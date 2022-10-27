using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.DTO.DataKonsumen
{
    public class CreateDataKonsumenRequest
    {
       
        public string Jalan { get; set; }
         public string Kelurahan { get; set; }
        public string Kecamatan { get; set; }
        public string Kota { get; set; }
        public string Propinsi { get; set; }
        public string KodePos { get; set; }
        public string NomorTelepon { get; set; }
        public string NomorFaks { get; set; }
        public string NomorHandphone { get; set; }

        public string JalanKirim { get; set; }
        public string KelurahanKirim { get; set; }
        public string KecamatanKirim { get; set; }
        public string KotaKirim { get; set; }
        public string PropinsiKirim { get; set; }
        public string KodePosKirim { get; set; }
        public string NomorTeleponKirim { get; set; }
        public string NomorFaksKirim { get; set; }
        public string NomorHandphoneKirim { get; set; }
        public string NamaDepan { get; set; }
        public string NamaBelakang { get; set; }
        public string NamaDepanBPKB { get; set; }
        public string NamaBelakangBPKB { get; set; }

        public string NomorKtp { get; set; }
        public int JenisKelamin { get; set; }
        public int Agama { get; set; }

        // [DataType(DataType.Text)]
        public DateTime TangggalLahir { get; set; }
        public int KodeBidangPekerjaan { get; set; }
        public string NamaBidangPekerjaan { get; set; }
        public int KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }
        public string Email { get; set; }
        //  public string UserIDPeg { get; set; }

        public string UserName { get; set; }
        public Guid UserNameId { get; set; }
    }
}
