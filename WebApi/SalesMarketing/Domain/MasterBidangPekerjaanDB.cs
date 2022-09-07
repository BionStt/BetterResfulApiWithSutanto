using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.Domain
{
    public class MasterBidangPekerjaanDB
    {
        public static MasterBidangPekerjaanDB CreateMasterBidangPekerjaanDB(string namaMasterBidangPekerjaan)
        {
            return new MasterBidangPekerjaanDB(namaMasterBidangPekerjaan);
        }
        private MasterBidangPekerjaanDB(string namaMasterBidangPekerjaan)
        {
            NamaMasterBidangPekerjaan = namaMasterBidangPekerjaan;
            MasterBidangPekerjaanDBGuid = Guid.NewGuid();
        }
        //[Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NoUrutId { get; private set; }
        public Guid MasterBidangPekerjaanDBGuid { get; private set; }
        public string NamaMasterBidangPekerjaan { get; private set; }
        public DateTime TanggalInput { get; private set; }
    }
}
