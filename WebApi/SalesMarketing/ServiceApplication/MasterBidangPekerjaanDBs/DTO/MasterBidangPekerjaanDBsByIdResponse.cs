using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.DTO
{
    public class MasterBidangPekerjaanDBsByIdResponse
    {
        public int NoUrutId { get; set; }
        public string MasterBidangPekerjaan { get; set; }
        public Guid MasterBidangPekerjaanId { get; set; }
    }
}
