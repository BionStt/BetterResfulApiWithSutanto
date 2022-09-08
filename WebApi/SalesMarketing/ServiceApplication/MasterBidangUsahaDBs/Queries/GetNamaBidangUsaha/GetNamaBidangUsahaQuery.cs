using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBidangUsahaDBs.Queries.GetNamaBidangUsaha
{
    public class GetNamaBidangUsahaQuery : IRequest<IReadOnlyCollection<GetNamaBidangUsahaResponse>>
    {

    }
}
