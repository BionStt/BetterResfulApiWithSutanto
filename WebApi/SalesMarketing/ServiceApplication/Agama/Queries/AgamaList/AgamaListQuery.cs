using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.Agama.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.Agama.Queries.AgamaList
{
    public class AgamaListQuery : IRequest<IReadOnlyCollection<AgamaListResponse>>
    {

    }
}
