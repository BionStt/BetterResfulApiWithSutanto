using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.Domain
{
    public class MasterBidangUsahaDB
    {
        public static MasterBidangUsahaDB CreateMasterBidangUsahaDB(string namaMasterBidangUsaha)
        {
            return new MasterBidangUsahaDB(namaMasterBidangUsaha);
        }
        private MasterBidangUsahaDB(string namaMasterBidangUsaha)
        {
            NamaMasterBidangUsaha = namaMasterBidangUsaha;
            MasterBidangUsahaGuid = Guid.NewGuid();
        }
        // [Key]
        // [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int NoUrutId { get; set; }
        public Guid MasterBidangUsahaGuid { get; set; }
        public string NamaMasterBidangUsaha { get; private set; }
        public DateTime TanggalInput { get; set; }
    }
}
