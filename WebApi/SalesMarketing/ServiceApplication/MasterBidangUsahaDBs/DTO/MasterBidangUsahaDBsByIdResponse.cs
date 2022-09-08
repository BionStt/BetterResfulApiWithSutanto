using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.DTO
{
    public class MasterBidangUsahaDBsByIdResponse
    {
        public int NoUrutId { get; set; }
        public string MasterBidangUsaha { get; set; }
        public Guid MasterBidangUsahaId { get; set; }
    }
}
