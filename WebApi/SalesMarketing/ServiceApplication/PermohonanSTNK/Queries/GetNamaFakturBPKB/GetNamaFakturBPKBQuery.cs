using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.ServiceApplication.PermohonanSTNK.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.PermohonanSTNK.Queries.GetNamaFakturBPKB
{
    public class GetNamaFakturBPKBQuery : IRequest<IReadOnlyCollection<GetNamaFakturBPKBResponse>>
    {

    }
}
