using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApi.SalesMarketing.ServiceApplication.Agama.DTO
{
    public class AgamaListByIdResponse
    {
        public Guid AgamaListByIdResponseId { get; set; }
        public int NoUrutId { get; set; }
        public string AgamaKeterangan { get; set; }
    }
}
