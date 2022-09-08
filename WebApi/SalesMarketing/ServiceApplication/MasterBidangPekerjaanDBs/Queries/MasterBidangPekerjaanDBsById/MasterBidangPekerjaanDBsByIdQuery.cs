using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangPekerjaanDBs.Queries.MasterBidangPekerjaanDBsById
{
    public class MasterBidangPekerjaanDBsByIdQuery : IRequest<MasterBidangPekerjaanDBsByIdResponse>
    {
        public int NoUrutId { get; set; }
    }
}
