using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Domain.Exception;
using WebApi.SalesMarketing.Domain.ValueObjects;

namespace WebApi.SalesMarketing.Domain
{
    public class DataKonsumen
    {
        public Guid DataKonsumenId { get; set; }
        public int NoUrutId { get; set; }
        public string NoKTP { get; private set; }
        public DateTime TanggalLahir { get; private set; }


        public Name Nama { get; private set; }
        public Name NamaBPKB { get; private set; }
        public Alamat AlamatTinggal { get; private set; }
        public Alamat AlamatKirim { get; private set; }
        public string Email { get; private set; }
        public Guid KodeBidangPekerjaan { get; set; }
        public string NamaBidangPekerjaan { get; set; }
        public Guid KodeBidangUsaha { get; set; }
        public string NamaBidangUsaha { get; set; }
        public DateTime CreatedAt { get; private set; }

        public Guid JenisKelaminId { get; private set; }
        public Guid AgamaId { get; private set; }
        public string Terinput { get; set; }
        public string UserName { get; set; }
        public Guid UserNameId { get; set; }

        //utk ef core
        protected DataKonsumen()
        {

        }

        private DataKonsumen(string noKTP, DateTime tanggalLahir, Guid jenisKelaminId, Name nama, Name namaBPKB, Alamat alamatTinggal, Alamat alamatKirim, Guid agamaId, string email, Guid kodeBidangPekerjaan, string namaBidangPekerjaan, Guid kodeBidangUsaha, string namaBidangUsaha, string userName, Guid userNameId)//, DateTime createdAt)
        {
            if (noKTP == null)
            {
                throw new InvalidDataKonsumenStateException("noKTP tidak bisa kosong");
            }
            if (jenisKelaminId == Guid.Empty)
            {
                throw new InvalidDataKonsumenStateException("jenisKelaminId tidak bisa kosong");
            }
            if (nama == null)
            {
                throw new InvalidDataKonsumenStateException("nama tidak bisa kosong");
            }
            if (namaBPKB == null)
            {
                throw new InvalidDataKonsumenStateException("namaBPKB tidak bisa kosong");
            }
            if (alamatTinggal == null)
            {
                throw new InvalidDataKonsumenStateException("alamatTinggal tidak bisa kosong");
            }
            if (alamatKirim == null)
            {
                throw new InvalidDataKonsumenStateException("alamatKirim tidak bisa kosong");
            }
            if (email == null)
            {
                throw new InvalidDataKonsumenStateException("email tidak bisa kosong");
            }
            if (namaBidangPekerjaan == null)
            {
                throw new InvalidDataKonsumenStateException("namaBidangPekerjaan tidak bisa kosong");
            }
            if (namaBidangUsaha == null)
            {
                throw new InvalidDataKonsumenStateException("namaBidangUsaha tidak bisa kosong");
            }

            DataKonsumenId = Guid.NewGuid();
            CreatedAt = DateTime.Now.Date;
            NoKTP = noKTP;
            TanggalLahir = tanggalLahir;
            JenisKelaminId = jenisKelaminId;
            Nama = nama;
            NamaBPKB = namaBPKB;
            AlamatTinggal = alamatTinggal;
            AlamatKirim = alamatKirim;
            AgamaId = agamaId;
            Email = email;
            KodeBidangPekerjaan = kodeBidangPekerjaan;
            NamaBidangPekerjaan = namaBidangPekerjaan;
            KodeBidangUsaha = kodeBidangUsaha;
            NamaBidangUsaha = namaBidangUsaha;
            UserName = userName;
            UserNameId = userNameId;
            // CreatedAt = createdAt;
        }



        public void SetTerinputPenjualan()
        {
            Terinput = "1";
        }
        public void SetBidangPekerjaan(Guid kodeBidangPekerjaan, string namaBidangPekerjaan)
        {
            KodeBidangPekerjaan = kodeBidangPekerjaan;
            NamaBidangPekerjaan = namaBidangPekerjaan;
        }
        public void SetBidangUsaha(Guid kodeBidangUsaha, string namaBidangUsaha)
        {
            if (kodeBidangUsaha == Guid.Empty)
            {
                throw new InvalidDataKonsumenStateException("Kode Bidang usaha tidak bisa kosong");
            }
            if (namaBidangUsaha == null)
            {
                throw new InvalidDataKonsumenStateException("Nama Bidang usaha tidak bisa kosong");
            }
            KodeBidangUsaha = kodeBidangUsaha;
            NamaBidangUsaha = namaBidangUsaha;
        }
        public void SetUserNameId(string userName, Guid userNameId)
        {
            if (userNameId == Guid.Empty)
            {
                throw new InvalidDataKonsumenStateException("userName Idtidak bisa kosong");
            }
            if (userName == null)
            {
                throw new InvalidDataKonsumenStateException("UserName tidak bisa kosong");
            }
            userName = userName;
            UserNameId = userNameId;
        }
        public static DataKonsumen Create(string nomorKTP, DateTime tanggalLahir, Guid jenisKelamin, Name nama, Name namaBpkb, Alamat alamatTinggal, Alamat alamatKirim, Guid agama, string email, Guid kodeBidangPekerjaan, string namaBidangPekerjaan, Guid kodeBidangUsaha, string namaBidangUsaha, string userName, Guid userNameId)
        {
            return new DataKonsumen(nomorKTP, tanggalLahir, jenisKelamin, nama, namaBpkb, alamatTinggal, alamatKirim, agama, email, kodeBidangPekerjaan, namaBidangPekerjaan, kodeBidangUsaha, namaBidangUsaha, userName, userNameId);
        }
        public void SetEmail(string email)
        {

            if (email == null)
            {
                throw new InvalidDataKonsumenStateException("Email tidak bisa kosong");
            }
            Email = email;
        }
        public void SetNama(string namaDepan, string namaBelakang, string namaDepanBPKB, string namaBelakangBPKB)
        {
            if (namaDepan == null)
            {
                throw new InvalidDataKonsumenStateException("namaDepan tidak bisa kosong");
            }
            if (namaBelakang == null)
            {
                throw new InvalidDataKonsumenStateException("namaBelakang tidak bisa kosong");
            }
            if (namaDepanBPKB == null)
            {
                throw new InvalidDataKonsumenStateException("namaDepanBPKB tidak bisa kosong");
            }
            if (namaBelakangBPKB == null)
            {
                throw new InvalidDataKonsumenStateException("namaBelakangBPKB tidak bisa kosong");
            }

            Nama = Domain.ValueObjects.Name.CreateName(namaDepan, namaBelakang);
            NamaBPKB = Domain.ValueObjects.Name.CreateName(namaDepanBPKB, namaBelakangBPKB);

        }
        public void SetTanggalLahirJenisKelamin(DateTime tanggalLahir, Guid jenisKelamin)
        {
            TanggalLahir = tanggalLahir;
            JenisKelaminId = JenisKelaminId;
        }
        public void SetAlamatKirim(string jalan, string kelurahan, string kecamatan, string kota, string propinsi, string kodepos, string notelepon, string nofax, string nohandphone)
        {
            if (jalan == null)
            {
                throw new InvalidDataKonsumenStateException("namaBjalanelakangBPKB tidak bisa kosong");
            }
            if (kelurahan == null)
            {
                throw new InvalidDataKonsumenStateException("kelurahan tidak bisa kosong");
            }
            if (kecamatan == null)
            {
                throw new InvalidDataKonsumenStateException("kecamatan tidak bisa kosong");
            }
            if (kota == null)
            {
                throw new InvalidDataKonsumenStateException("kota tidak bisa kosong");
            }
            if (propinsi == null)
            {
                throw new InvalidDataKonsumenStateException("propinsi tidak bisa kosong");
            }
            if (kodepos == null)
            {
                throw new InvalidDataKonsumenStateException("kodepos tidak bisa kosong");
            }
            if (notelepon == null)
            {
                throw new InvalidDataKonsumenStateException("notelepon tidak bisa kosong");
            }
            if (nofax == null)
            {
                throw new InvalidDataKonsumenStateException("nofax tidak bisa kosong");
            }
            if (nohandphone == null)
            {
                throw new InvalidDataKonsumenStateException("nohandphone tidak bisa kosong");
            }
            AlamatKirim = Domain.ValueObjects.Alamat.CreateAlamat(jalan, kelurahan, kecamatan, kota, propinsi, kodepos, notelepon, nofax, nohandphone);
        }
        public void SetAlamatTinggal(string jalan, string kelurahan, string kecamatan, string kota, string propinsi, string kodepos, string notelepon, string nofax, string nohandphone)
        {
            if (jalan == null)
            {
                throw new InvalidDataKonsumenStateException("namaBjalanelakangBPKB tidak bisa kosong");
            }
            if (kelurahan == null)
            {
                throw new InvalidDataKonsumenStateException("kelurahan tidak bisa kosong");
            }
            if (kecamatan == null)
            {
                throw new InvalidDataKonsumenStateException("kecamatan tidak bisa kosong");
            }
            if (kota == null)
            {
                throw new InvalidDataKonsumenStateException("kota tidak bisa kosong");
            }
            if (propinsi == null)
            {
                throw new InvalidDataKonsumenStateException("propinsi tidak bisa kosong");
            }
            if (kodepos == null)
            {
                throw new InvalidDataKonsumenStateException("kodepos tidak bisa kosong");
            }
            if (notelepon == null)
            {
                throw new InvalidDataKonsumenStateException("notelepon tidak bisa kosong");
            }
            if (nofax == null)
            {
                throw new InvalidDataKonsumenStateException("nofax tidak bisa kosong");
            }
            if (nohandphone == null)
            {
                throw new InvalidDataKonsumenStateException("nohandphone tidak bisa kosong");
            }
            AlamatTinggal = Domain.ValueObjects.Alamat.CreateAlamat(jalan, kelurahan, kecamatan, kota, propinsi, kodepos, notelepon, nofax, nohandphone);
        }
    }
}
