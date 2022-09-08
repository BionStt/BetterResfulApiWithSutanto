using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.MasterBarang.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.MasterBarang.Queries.GetNamaBarang
{
    public class GetNamaBarangQuery : IRequest<IReadOnlyCollection<GetNamaBarangResponse>>
    {

    }
}
