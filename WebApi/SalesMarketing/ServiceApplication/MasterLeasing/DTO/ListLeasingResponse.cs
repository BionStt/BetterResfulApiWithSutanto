using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.ServiceApplication.MasterLeasing.DTO
{
    public class ListLeasingResponse
    {
        public int NoUrutId { get; set; }
        public Guid LeasingId { get; set; }
        public string NamaLeasing { get; set; }
    }
}
