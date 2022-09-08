using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebApi.SalesMarketing.Infrastructure.Context;
using WebApi.SalesMarketing.ServiceApplication.DataSPK.DTO;

namespace WebApi.SalesMarketing.ServiceApplication.DataSPK.Queries.GetNamaSPK
{
    public class GetNamaSPKQueryHandler : IRequestHandler<GetNamaSPKQuery, IReadOnlyCollection<GetNamaSPKResponse>>
    {
        private readonly SalesMarketingContext _context;

        public GetNamaSPKQueryHandler(SalesMarketingContext context)
        {
            _context = context;
        }

        public async Task<IReadOnlyCollection<GetNamaSPKResponse>> Handle(GetNamaSPKQuery request, CancellationToken cancellationToken)
        {
            var returnQuery = await _context.DataSPKSurvei.Select(x => new GetNamaSPKResponse
            {
                NamaPemesan = string.Format("{0}-{1}", x.NamaPemesan.NamaDepan, x.NamaPemesan.NamaBelakang),
                NoUrutSPKBaru1 = x.NoUrutId
            }).OrderByDescending(x => x.NoUrutSPKBaru1).AsNoTracking().ToListAsync();


            return returnQuery;

        }
    }
}
