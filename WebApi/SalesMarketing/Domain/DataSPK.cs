using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Domain.ValueObjects;

namespace WebApi.SalesMarketing.Domain
{
    public class DataSPK
    {
        private DataSPK(string lokasiSpk, string userNameInput, Guid userNameId)
        {
            if (lokasiSpk == null) throw new ArgumentNullException("Lokasi SPK tidak boleh kosong");
            DataSPKId = Guid.NewGuid();
            NoRegistrasiSPK = KodeRegistrasi(DateTime.Now);
            LokasiSpk = lokasiSpk;
            //  Terinput = terinput;
            //   TanggalInput = tanggalInput;
            //  Tolak = tolak;
            //UserId = userId;
            UserNameInput = userNameInput;
            StatusSPK = 0;
            UserNameId = userNameId;
        }
        public static DataSPK CreateDataSPKBaru(string lokasiSpk, string userNameInput, Guid userNameId)
        {
            return new DataSPK(lokasiSpk, userNameInput, userNameId);
        }
        public void AccDanTerjual()
        {
            StatusSPK = 3;
        }
        public void Ditolak()
        {
            Tolak = "1";
        }


        private string KodeRegistrasi(DateTime Tanggal)
        {
            var NoRegistrasiSPK = string.Format("{0}{1}{2}{3}", Tanggal.Year.ToString(), Tanggal.Month.ToString(), DateTime.UtcNow.Date.Day.ToString(), Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSPK");

            //var NoRegistrasiSPK = DateTime.UtcNow.Date.Year.ToString() +
            //  DateTime.UtcNow.Date.Month.ToString() +
            //  DateTime.UtcNow.Date.Day.ToString() + Guid.NewGuid().ToString().Substring(0, 4).ToUpper() + "REGSPK";

            return NoRegistrasiSPK;

        }
        //private string GenerateId(int travelerId, DateTime firstNight, DateTime lastNight, DateTime booked)
        //{
        //    return string.Format(
        //        "{0}-{1}-{2}-{3}",
        //        travelerId, ToIdFormat(firstNight), ToIdFormat(lastNight), ToIdFormat(booked)
        //    );
        //}

        //private string ToIdFormat(DateTime date)
        //{
        //    return date.ToString("yyyy/MM/dd");
        //}

        protected DataSPK()
        {

        }
        public Guid DataSPKId { get; set; }
        public string NoRegistrasiSPK { get; private set; }
        public string LokasiSpk { get; private set; }

        public int StatusSPK { get; private set; }

        public DateTime? TanggalInput { get; private set; }
        public string Tolak { get; private set; }
        public Guid? UserId { get; private set; }
        public string? UserNameInput { get; private set; }
        public Guid UserNameId { get; private set; }
        public int NoUrutId { get; set; }

        private readonly List<DataSPKSurvei> _dataSPKSurvei = new List<DataSPKSurvei>();
        public IReadOnlyCollection<DataSPKSurvei> DataSPKSurvei => _dataSPKSurvei.AsReadOnly();

       // public void AddDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan, Guid DataSpkId)
        public void AddDataSPKSurvei(DataSPKSurvei DataSPKSurvei1)
        {
           // var DtSPKSurvei = Domain.DataSPKSurvei.CreateDataSPKSurvei(noKTPPemesan, namaPemesan, alamatPemesan, dataNPWPPemesan, pekerjaanPemesan, DataSpkId);
            _dataSPKSurvei.Add(DataSPKSurvei1);
           // return DtSPKSurvei;
        }
        public void EditDataSPKSurvei(string noKTPPemesan, Name namaPemesan, Alamat alamatPemesan, DataNPWP dataNPWPPemesan, string pekerjaanPemesan, Guid DataSpkSurveiId)
        {
            var dataSPKSurvei = _dataSPKSurvei.FirstOrDefault(i => i.DataSPKSurveiId == DataSpkSurveiId);
            dataSPKSurvei.EditDataSPKSurvei(noKTPPemesan, namaPemesan, alamatPemesan, dataNPWPPemesan, pekerjaanPemesan);
           // return dataSPKSurvei;
        }

        private readonly List<DataSPKLeasing> _dataSpkLeasing = new List<DataSPKLeasing>();
        public IReadOnlyCollection<DataSPKLeasing> DataSPKLeasing => _dataSpkLeasing.AsReadOnly();

       // public void AddDataSPKLeasing(decimal? angsuran, string mediator, string namaCmo, Guid namaSales, int? tenor, DateTime? tanggalSurvei, Guid DataSpkId)
        public void AddDataSPKLeasing(DataSPKLeasing DataSPKLeasing1)
        {
            //var dataSpkLeasing = Domain.DataSPKLeasing.CreateDataSPKLeasing(angsuran, mediator, namaCmo, namaSales, tenor, tanggalSurvei, DataSpkId);
            _dataSpkLeasing.Add(DataSPKLeasing1);
           // return dataSpkLeasing;
        }
        public DataSPKLeasing EditDataSpkLeasing(decimal? angsuran, string mediator, string namaCmo, Guid namaSales, int? tenor, DateTime? tanggalSurvei, Guid DataSPKLEasingId)
        {
            var dataSpkLeasing = _dataSpkLeasing.FirstOrDefault(i => i.DataSPKLeasingId == DataSPKLEasingId);
            dataSpkLeasing.EditDataSpkLeasing(angsuran, mediator, namaCmo, namaSales, tenor, tanggalSurvei);
            return dataSpkLeasing;
        }

        private readonly List<DataSPKKredit> _dataSpkKredit = new List<DataSPKKredit>();
        public IReadOnlyCollection<DataSPKKredit> DataSPKKredit => _dataSpkKredit.AsReadOnly();
      
        //public void AddDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit, string userName, Guid userNameId)
        public void AddDataSPKKredit(DataSPKKredit DataSPKKredit1)
        {
           //var dataSPKKredit = Domain.DataSPKKredit.CreateDataSPKKredit(biayaAdministrasiKredit, biayaAdministrasiTunai, bBN, dendaWilayah, diskonDP, diskonTunai, dPPriceList, komisi, offTheRoad, promosi, uangTandaJadiTunai, uangTandaJadiKredit, DataSPKId, userName, userNameId);
            _dataSpkKredit.Add(DataSPKKredit1);
           // return dataSPKKredit;
        }
        public void EditDataSPKKredit(decimal? biayaAdministrasiKredit, decimal? biayaAdministrasiTunai, decimal? bBN, decimal? dendaWilayah, decimal? diskonDP, decimal? diskonTunai, decimal? dPPriceList, decimal? komisi, decimal? offTheRoad, decimal? promosi, decimal? uangTandaJadiTunai, decimal? uangTandaJadiKredit, Guid DataSpkKreditId)
        {
            var dataspkKredit = _dataSpkKredit.FirstOrDefault(i => i.DataSPKKreditId == DataSpkKreditId);
            dataspkKredit.EditDataSPKKredit(biayaAdministrasiKredit, biayaAdministrasiTunai, bBN, dendaWilayah, diskonDP, diskonTunai, dPPriceList, komisi, offTheRoad, promosi, uangTandaJadiTunai, uangTandaJadiKredit);
          //  return dataspkKredit;

        }

        private readonly List<DataSPKKendaraan> _dataSPKKendaraan = new List<DataSPKKendaraan>();
        public IReadOnlyCollection<DataSPKKendaraan> DataSPKKendaraan => _dataSPKKendaraan.AsReadOnly();

       // public void AddDataSPKKendaraan(string TahunPerakitan,string Warna,string NamaSTNK,string NoKTPSTNK, Guid MasterBarangIdGuid, Guid dtSPKId,string UserName,Guid UserNameId)
        public void AddDataSPKKendaraan(DataSPKKendaraan DataSPKKendaraan1)
        {
          //  var dataSpkKendaraan = Domain.DataSPKKendaraan.CreateDataSPKKendaraan(TahunPerakitan, Warna, NamaSTNK, NoKTPSTNK, MasterBarangIdGuid, dtSPKId, UserName, UserNameId);
            _dataSPKKendaraan.Add(DataSPKKendaraan1);
           // return dataSpkKendaraan;
        }

    }
}
