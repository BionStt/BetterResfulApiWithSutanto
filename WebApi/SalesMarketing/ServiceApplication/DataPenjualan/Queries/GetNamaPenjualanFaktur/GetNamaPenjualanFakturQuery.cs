using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.DataPenjualan.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataPenjualan.Queries.GetNamaPenjualanFaktur
{
    public class GetNamaPenjualanFakturQuery : IRequest<IReadOnlyCollection<GetNamaPenjualanFakturResponse>>
    {

    }
}
