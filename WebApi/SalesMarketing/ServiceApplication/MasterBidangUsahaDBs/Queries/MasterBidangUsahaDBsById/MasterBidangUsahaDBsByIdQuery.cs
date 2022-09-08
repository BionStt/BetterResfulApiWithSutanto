using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries.MasterBidangUsahaDBsById
{
    public class MasterBidangUsahaDBsByIdQuery : IRequest<MasterBidangUsahaDBsByIdResponse>
    {
        public int NoUrutId { get; set; }
    }
}
