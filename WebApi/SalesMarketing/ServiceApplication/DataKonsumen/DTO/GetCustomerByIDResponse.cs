﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.ServiceApplication.DataKonsumen.DTO
{
    public class GetCustomerByIDResponse
    {
        //  public int NoUrutKendaraan { get; set; }
        public string NoKodeCustomer { get; set; }
        public int CustomerID { get; set; }
       
        public string Jalan { get; set; }
      
        public string Kelurahan { get; set; }
      
        public string Kecamatan { get; set; }
     
        public string Kota { get; set; }
      
        public string Propinsi { get; set; }
      
        public string KodePos { get; set; }
      
        public string NoTelepon { get; set; }
     
        public string NoFax { get; set; }
      
        public string NoHandphone { get; set; }

      
        public string JalanKirim { get; set; }
       
        public string KelurahanKirim { get; set; }
     
        public string KecamatanKirim { get; set; }
      
        public string KotaKirim { get; set; }
       
        public string PropinsiKirim { get; set; }
      
        public string KodePosKirim { get; set; }
       
        public string NoTeleponKirim { get; set; }
       
        public string NoFaxKirim { get; set; }
      
        public string NoHandphoneKirim { get; set; }


        public string Jual { get; set; }

        public string Nama { get; set; }
        public string NamaBPKB { get; set; }
        public string NoKtp { get; set; }
        public string Email { get; set; }

        public string TelpKantor { get; set; }
        public DateTime? TglInput { get; set; }
        public DateTime TglLahir { get; set; }
        public int? UserIDPeg { get; set; }
        public string UserInput { get; set; }
        public string KodeBidangPekerjaan { get; set; }
        public string NamaBidangPekerjaan { get; set; }
        public string KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }
    }
}
