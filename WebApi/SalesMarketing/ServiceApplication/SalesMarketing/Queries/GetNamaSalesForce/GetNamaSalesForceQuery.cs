using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.SalesMarketing.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.SalesMarketing.Queries.GetNamaSalesForce
{
    public class GetNamaSalesForceQuery : IRequest<IReadOnlyCollection<GetNamaSalesForceResponse>>
    {

    }
}
