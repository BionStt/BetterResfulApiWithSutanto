using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.DataKonsumen.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataKonsumen.Queries.GetCustomerDataPenjualan
{
    public class GetCustomerDataPenjualanQuery : IRequest<IReadOnlyCollection<GetCustomerDataPenjualanResponse>>
    {

    }
}
