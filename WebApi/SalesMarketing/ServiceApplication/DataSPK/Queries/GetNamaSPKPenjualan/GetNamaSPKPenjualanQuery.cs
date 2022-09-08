using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.DataSPK.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataSPK.Queries.GetNamaSPKPenjualan
{
    public class GetNamaSPKPenjualanQuery : IRequest<IReadOnlyCollection<GetNamaSPKPenjualanResponse>>
    {

    }
}
